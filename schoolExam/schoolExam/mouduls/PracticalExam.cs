namespace schoolExam.mouduls;
public class PracticalExam : Exam
{
    public PracticalExam(TimeSpan timeLimit, Question[] questions, Subject subject)
        : base(timeLimit, questions, subject)
    {
        // Add Any Method check if all questions are MCQ
        if (questions.Any(q => q is not QuestionMCQ))
        {
            throw new ArgumentException("Practical Exam can only contain MCQ questions.");
        }
    }

    public override void ShowExam()
    {
        Console.WriteLine($"*** PRACTICAL EXAM: {ExamSubject.SubjectName} ***");
        Console.WriteLine($"Time Limit: {TimeLimit.TotalMinutes} minutes | Total Questions: {NumberOfQuestions}");

        foreach (var question in Questions)
        {
            question.DisplayQuestion();

            // Practical Exam specific feature: Show the right answer
            var rightAnswer = question.AnswerList.FirstOrDefault(a => a.Id == question.RightAnswerId);
            if (rightAnswer != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n[Right Answer: {rightAnswer.TextAnserwer}]");
                Console.ResetColor();
            }
        }
        Console.WriteLine("\n--- Practical Exam Finished ---");
    }
}