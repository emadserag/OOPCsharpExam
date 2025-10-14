public class Patient : Person
{
    public string Disease { get; set; }
    public DateTime AdmissionDate { get; private set; }
    public DateTime DischargeDate { get; private set; }
    public bool IsAdmitted { get; private set; }
    public int? RoomNumber { get; private set; }

    public Patient(string id, string name, int age, Gender gender, string disease)
        : base(id, name, age, gender) 
    {
        this.Disease = disease;
        this.IsAdmitted = false; 
        this.RoomNumber = null;  
    }

    /// <summary>
    ///Create a new admission for the patient.
    /// </summary>
    public void Admit(DateTime date, int roomNumber)
    {
        if (IsAdmitted)
        {
            Console.WriteLine($"Patient {Name} is already admitted.");
            return;
        }
        AdmissionDate = date;
        RoomNumber = roomNumber;
        IsAdmitted = true;
        DischargeDate = DateTime.MinValue; 
        Console.WriteLine($"Patient {Name} admitted to Room {RoomNumber} on {AdmissionDate.ToShortDateString()}");
    }

    /// <summary>
    ///  Logout the patient from the hospital.
    /// </summary>
    public void Discharge(DateTime date)
    {
        if (!IsAdmitted)
        {
            Console.WriteLine($"Patient {Name} is not currently admitted.");
            return;
        }

        if (date < AdmissionDate)
        {
            throw new ArgumentException("Discharge date cannot be before admission date.");
        }

        DischargeDate = date;
        IsAdmitted = false;
        RoomNumber = null;
        Console.WriteLine($"Patient {Name} discharged on {DischargeDate.ToShortDateString()}");
    }

    /// <summary>
    /// calculate the total number of days the patient has stayed in the hospital.
    /// </summary>
  
    public int CalculateStayDuration()
    {
        DateTime endDate = IsAdmitted ? DateTime.Today : DischargeDate;

        if (AdmissionDate == DateTime.MinValue || endDate <= AdmissionDate)
        {
            return 0;
        }

    
        TimeSpan duration = endDate - AdmissionDate;
        return (int)Math.Ceiling(duration.TotalDays); 
    }

 

    public override void DisplayInfo()
    {
        string status = IsAdmitted
            ? $"Admitted (Room: {RoomNumber}, Since: {AdmissionDate.ToShortDateString()})"
            : $"Discharged (Stay: {CalculateStayDuration()} days)";

        Console.WriteLine($"Patient Info: ID={Id}, Name={Name}, Age={Age}, Disease={Disease}, Status: {status}");
    }


    /// <summary>
    /// يقوم بإنشاء نسخة عميقة (Deep Copy) من كائن المريض الحالي.
    /// </summary>
    public Patient DeepClone()
    {
       
        Patient newPatient = new Patient(this.Id, this.Name, this.Age, this.Gender, this.Disease)
        {
            AdmissionDate = this.AdmissionDate,
            DischargeDate = this.DischargeDate,
            IsAdmitted = this.IsAdmitted,
            RoomNumber = this.RoomNumber
        };

        return newPatient;
    }


    /// <summary>
    /// Returns the role of the person as "Patient".
    /// </summary>
    public static explicit operator int(Patient patient)
    {
        return patient.CalculateStayDuration();
    }
    public class StayDurationComparer : IComparer<Patient>
    {
        public int Compare(Patient? x, Patient? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            int durationX = x.CalculateStayDuration();
            int durationY = y.CalculateStayDuration();

            return durationX.CompareTo(durationY);
        }
    }
}