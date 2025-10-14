public class Subject
{
    public int SubjectId { get; set; }
    public string SubjectName { get; set; }
    public Exam SubjectExam { get; private set; }

    public Subject(int id, string name)
    {
        SubjectId = id;
        SubjectName = name;
    }

    public void CreateSubjectExam(Exam exam)
    {
        SubjectExam = exam;
        Console.WriteLine($"\nExam for '{SubjectName}' created successfully.");
    }

    public override string ToString() => $"Subject ID: {SubjectId}, Name: {SubjectName}";
}