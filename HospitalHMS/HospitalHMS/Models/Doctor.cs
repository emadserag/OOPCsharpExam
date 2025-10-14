public sealed class Doctor : Person, IComparable<Doctor>
{
    
    public string Specialization { get; set; }
    public decimal Salary { get; set; }
    public static int DoctorCount = 0;
    public Doctor(string id, string name, int age, Gender gender, string specialization, decimal salary)
           : base(id, name, age, gender)
    {

        if (salary <= 0)
        {
            Console.WriteLine("A7na msh bnash7t ... !"); ;
        }

        this.Specialization = specialization;
        this.Salary = salary;

       
       
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Doctor Info: ID={Id}, Name={Name}, Age={Age}, Gender={Gender}, Specialization={Specialization}, Salary={Salary:C}, Role={GetRole()}");
    }
    public override string GetRole()
    {
        return "Doctor";
    }

    public int CompareTo(Doctor? other)
    {
        if (other == null) return 1;
        return this.Salary.CompareTo(other.Salary);
    }

    public static bool operator ==(Doctor? a, Doctor? b)
    {
     
        if (Equals(a, b)) return true;
        if (Equals(a, null) || Equals(b, null)) return false;

   
        return a.Id == b.Id;
    }

    public static bool operator !=(Doctor? a, Doctor? b)
    {
        return !(a == b);
    }
    public override bool Equals(object? obj)
    {
        return this == (obj as Doctor);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}