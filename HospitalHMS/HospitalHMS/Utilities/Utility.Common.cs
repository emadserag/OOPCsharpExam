using System;


using System.Collections.Generic;
using System.Linq;
using HospitalHMS.Interfaces;
using HospitalHMS.Utilities;
using static HospitalHMS.Models.Enums;
public class Billing : IBillable
{

    public string BillId { get; }
    public string PatientId { get; }
    public List<(BillItemType Type, string Description, decimal Amount)> Items { get; }


    public Billing(Patient patient) : this(patient.Id);
    public Billing(string patientId)
    {
        BillId = Utility.GenerateId("BILL");
        PatientId = patientId;
        Items = new List<(BillItemType Type, string Description, decimal Amount)>();
        Utility.RecordAction($"biuld recourd : {BillId} clinet: {PatientId}");
    }
    public void AddItem(BillItemType type, string description, decimal amount)
    {
        Items.Add((type, description, amount));
        Utility.RecordAction($"{BillId}: {type} - {description} price {Utility.FormatCurrency(amount)}");
    }

    public decimal CalculateBill()
    {
        return Items.Sum(item => item.Amount);
    }

    /// <summary>
    ///print the invoice details
    /// </summary>
    public void PrintInvoice()
    {
        Utility.Title($"Num : {BillId} ==> {PatientId}");
        Console.WriteLine($"Date : {DateTime.Now:g}");
        Utility.PrintSeparator('-');

        foreach (var item in Items)
        {
            Console.WriteLine($"{item.Type,-15} | {item.Description,-30} | {Utility.FormatCurrency(item.Amount)}");
        }

        Utility.PrintSeparator('-');
        Console.WriteLine($"Total : {Utility.FormatCurrency(CalculateBill())}");
        Utility.PrintSeparator('-');
    }

    /// <summary>
    /// return the total bill amount when casting to decimal.
    /// </summary>
    public static implicit operator decimal(Billing b)
    {
        return b.CalculateBill();
    }
}