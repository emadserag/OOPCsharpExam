using schoolExam.mouduls;
public class QuestionMCQ : Question
{
    public QuestionMCQ(string header, string body, int mark, Answer[] answers, int rightAnswerId)
        : base(header, body, mark, answers, rightAnswerId)
    {
        if (!answers.Any(a => a.Id == rightAnswerId))
        {

            Console.WriteLine("The right answer ID must exist");
        }
    }

    public override void DisplayQuestion()
    {
        Console.WriteLine($"\n[MCQ] {Header}: {Body} ({Mark} marks)");
        foreach (var answer in AnswerList)
        {
            Console.WriteLine(answer);
        }
    }
}