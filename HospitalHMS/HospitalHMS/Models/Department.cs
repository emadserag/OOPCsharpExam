public class Department
{
 
    public string DepartmentName { get; set; }

  
    public Doctor HeadDoctor { get; private set; }

    
    public List<Doctor> Doctors { get; private set; }
    public List<Nurse> Nurses { get; private set; }

   
    public Department(string departmentName, Doctor headDoctor)
    {
     
        if (headDoctor == null)
        {
           Console.WriteLine("Department must have a Head Doctor.");
        }

        this.DepartmentName = departmentName;
        this.HeadDoctor = headDoctor;


        this.Doctors = new List<Doctor>();
        this.Nurses = new List<Nurse>();
    }

    public void AddDoctor(Doctor doctor)
    {
        if (doctor == null) return;
        if (!Doctors.Contains(doctor))
        {
            Doctors.Add(doctor);
            Console.WriteLine($"Doctor {doctor.Name} added to {DepartmentName}.");
        }
    }

    public void AddNurse(Nurse nurse)
    {
        if (nurse == null) return;
        if (!Nurses.Contains(nurse))
        {
            Nurses.Add(nurse);
            Console.WriteLine($"Nurse {nurse.Name} added to {DepartmentName}.");
        }
    }

    public void DisplayDepartmentDetails()
    {
        Console.WriteLine($" Department: {DepartmentName}");
        HeadDoctor.DisplayInfo();

        Console.WriteLine($"Doctors ({Doctors.Count}) ");
        if (Doctors.Count == 0) Console.WriteLine("No additional doctors in this department.");
        else
        {
            foreach (var doc in Doctors)
            {
                doc.DisplayInfo();
            }
        }

        Console.WriteLine($" Nurses : ({Nurses.Count}) ");
        if (Nurses.Count == 0) 
            Console.WriteLine("No nurses in this department.");
        else
        {
            foreach (var nurse in Nurses)
            {
                nurse.DisplayInfo();
            }
        }
       
    }
}