using HospitalHMS.Interfaces;

public class Nurse : Person, IStaff
{
    public int ShiftHours { get; set; }

  
    public Nurse(string id, string name, int age, Gender gender, int shiftHours)
        : base(id, name, age, gender) 
    {
        this.ShiftHours = shiftHours;
    }
    public void PerformDuty()
    {
        Console.WriteLine($"Nurse {Name} is assisting patients.");
    }

    public decimal CalculateMonthlyBonus()
    {
      
        return ShiftHours > 160 ? 1000m : 500m;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Nurse Info: ID={Id}, Name={Name}, Age={Age}, Gender={Gender}, Shift Hours={ShiftHours}, Bonus={CalculateMonthlyBonus():C}, Role={GetRole()}");
    }
    public new string GetRole()
    {
        return "Nurse";
    }

   
}