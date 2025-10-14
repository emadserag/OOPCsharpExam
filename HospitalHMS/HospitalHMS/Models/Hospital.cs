
public static class Hospital
{
    public static List<Department> Departments { get; }
    public static List<Doctor> Doctors { get; }
    public static List<Nurse> Nurses { get; }
    public static List<Patient> Patients { get; }
    public static List<Room> Rooms { get; }

    static Hospital()
    {
        Departments = new List<Department>();
        List<Doctor> doctors = new();
        Doctors = doctors;
        Nurses = new List<Nurse>();
        Patients = new List<Patient>();
        Rooms = new List<Room>();

    
        Console.WriteLine("Initializing Hospital Data...");
        Rooms.Add(new Room(101, RoomType.Single));
        Rooms.Add(new Room(102, RoomType.Single));
        Rooms.Add(new Room(201, RoomType.Double));
        Rooms.Add(new Room(202, RoomType.Double));
        Rooms.Add(new Room(301, RoomType.VIP));
    }
    public static void AddDepartment(Department dep)
    {
        if (dep != null && !Departments.Any(d => d.DepartmentName == dep.DepartmentName))
        {
            Departments.Add(dep);
           
            if (dep.HeadDoctor != null && !Doctors.Contains(dep.HeadDoctor))
            {
                Doctors.Add(dep.HeadDoctor);
            }
            foreach (var doc in dep.Doctors)
            {
                if (!Doctors.Contains(doc)) Doctors.Add(doc);
            }
       
            Console.WriteLine($"Department '{dep.DepartmentName}' added.");
        }
    }

    public static IEnumerable<Department> ListDepartments()
    {
        return Departments;
    }


    /// <summary>
    /// search for doctors by their specialization.
    /// </summary>
    public static IEnumerable<Doctor> SearchDoctorBySpecialization(string spec)
    {
        if (string.IsNullOrWhiteSpace(spec))
        {
            return Enumerable.Empty<Doctor>();
        }
   
        return Doctors.Where(d => d.Specialization.Equals(spec, StringComparison.OrdinalIgnoreCase));
    }
    public static int? BookAnyAvailableRoom(RoomType? preferred = null)
    {
        Room? roomToBook = null;

        if (preferred.HasValue)
        {
      
            roomToBook = Rooms.FirstOrDefault(r => !r.IsOccupied && r.Type == preferred.Value);
        }

        if (roomToBook == null)
        {
     
            roomToBook = Rooms.FirstOrDefault(r => !r.IsOccupied);
        }

        if (roomToBook != null)
        {
            roomToBook.IsOccupied = true;
            Console.WriteLine($"Room {roomToBook.RoomNumber} ({roomToBook.Type}) booked.");
            return roomToBook.RoomNumber;
        }

        Console.WriteLine("No available rooms found.");
        return null; 
    }

 
    public static bool ReleaseRoom(int roomNumber)
    {
        Room? roomToRelease = Rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

        if (roomToRelease != null && roomToRelease.IsOccupied)
        {
            roomToRelease.IsOccupied = false;
            Console.WriteLine($"Room {roomNumber} released.");
            return true;
        }
        return false;
    }
}