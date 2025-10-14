using schoolExam.mouduls;
using System;

public class TrueOrFalseQuestion : Question
{
    private static readonly Answer[] Answers = new Answer[]
    {
        new Answer(1, "True"), // في حالة True الإجابة الصحيحة
        new Answer(2, "False") // في حالة False الإجابة الخاطئة
    };
    public TrueOrFalseQuestion(string header, string body, int mark, int rightAnswerId)
        : base(header, body, mark, Answers, rightAnswerId)
    {
        if (rightAnswerId != 1 && rightAnswerId != 2)
            throw new ArgumentException("Right Answer ID for T || F must be 1 (True) or 2 (False).");
    }
    // عرض السؤال مع الخيارات
    public override void DisplayQuestion()
    {
        Console.WriteLine($"\n[True or False Question]  \n {Header}: {Body} \t\t ({Mark} marks)");
       
    }
}