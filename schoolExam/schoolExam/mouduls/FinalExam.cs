
namespace schoolExam.mouduls;
using System;
using System.Linq;

public class FinalExam : Exam
{
    public FinalExam(TimeSpan timeLimit, Question[] questions, Subject subject)
        : base(timeLimit, questions, subject)
    {
        if (questions.Any(q => q is not TrueOrFalseQuestion and not QuestionMCQ))
        {
            Console.WriteLine("Warning: Final Exam contains unallowed question types.");
        }
    }

    // Final Exam specific implementation: Shows questions, answers, and grade summary
    public override void ShowExam()
    {
       
        Console.WriteLine($"*** FINAL EXAM: {ExamSubject.SubjectName} ***");
        Console.WriteLine($"Time Limit: {TimeLimit.TotalMinutes} minutes | Total Questions: {NumberOfQuestions}");
        Console.WriteLine($"Maximum Grade: {GetTotalGrade()}");

        foreach (var question in Questions)
        {
            question.DisplayQuestion();
        }
        Console.WriteLine("\n--- End of Final Exam Questions ---");
    }
}
