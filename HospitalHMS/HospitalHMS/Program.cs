


// Display Doctor
Doctor doc1 = new Doctor("D001", "Ahmed Ali", 45, Gender.male, "Cardiology", 150000m);
Doctor doc2 = new Doctor("D002", "Layla Omar", 30, Gender.female, "Pediatrics", 95000m);

Console.WriteLine($"Total Doctors: {Doctor.DoctorCount}"); // ===> 2

doc1.DisplayInfo();
Console.WriteLine($"Doc1 Role: {doc1.GetRole()}");


// (IComparable)
Console.WriteLine($"Doc1 CompareTo Doc2 (Salary): {doc1.CompareTo(doc2)}");



Nurse nurseA = new Nurse("N10A", "Sara", 28, Gender.female, 170);
Nurse nurseB = new Nurse("N10B", "Yazan", 32, Gender.male, 140);


Department surgery = new Department("General Surgery", doc2);

surgery.AddDoctor(doc2);
surgery.AddNurse(nurseA);
surgery.AddNurse(nurseB);


surgery.DisplayDepartmentDetails();
Console.Write($"\n{nurseA.Name}'s Duty: ");
nurseA.PerformDuty();
Console.WriteLine($"Monthly Bonus: {nurseA.CalculateMonthlyBonus():C}");


// Display & Create a Patient
Patient p1 = new Patient("P101", "Fahd Khalid", 60, Gender.male, "KSA");
p1.DisplayInfo(); // Discharged (Stay: 0 days)

// register the patient
p1.Admit(new DateTime(2025, 10, 1), 305);

// logout the patient info after admission
p1.Discharge(new DateTime(2025, 10, 11));


p1.DisplayInfo(); //  Discharged (Stay: 10 days)

int stayDays = (int)p1;
Console.WriteLine($"Stay Duration via Cast: {stayDays} days"); 


Patient p2 = new Patient("P102", "Maha Samir", 35, Gender.female, "Fever");
p2.Admit(new DateTime(2025, 10, 1), 101);
p2.Discharge(new DateTime(2025, 10, 5)); 

Patient[] patients = { p1, p2 };
Array.Sort(patients, new Patient.StayDurationComparer());

Console.WriteLine("\nSorted by Stay Duration:");
foreach (var p in patients)
{
    Console.WriteLine($"- {p.Name} stayed for {p.CalculateStayDuration()} days");
}


// Hospital Operations && Room Booking
int? bookedVip = Hospital.BookAnyAvailableRoom(RoomType.VIP); 

Console.WriteLine($"Booked Room: {bookedVip}"); // ==301

// booking any available room
int? bookedAny = Hospital.BookAnyAvailableRoom(); //  101 أو 102
Console.WriteLine($"Booked Room: {bookedAny}");


var cardiologyDocs = Hospital.SearchDoctorBySpecialization("Cardiology");
Console.WriteLine($"\nFound {cardiologyDocs.Count()} doctors in Cardiology.");


if (bookedVip.HasValue)
{
    Hospital.ReleaseRoom(bookedVip.Value); //  301
}