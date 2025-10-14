public abstract class Exam
{
    public TimeSpan TimeLimit { get; set; }
    public int NumberOfQuestions => Questions?.Length ?? 0;
    public Question[] Questions { get; protected set; }
    public Subject ExamSubject { get; set; }

    public Exam(TimeSpan timeLimit, Question[] questions, Subject subject)
    {
        TimeLimit = timeLimit;
        Questions = questions;
        ExamSubject = subject;
    }

    public abstract void ShowExam();

    public int GetTotalGrade() => Questions.Sum(q => q.Mark);
}