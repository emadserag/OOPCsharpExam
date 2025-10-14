using schoolExam.mouduls;

public abstract class Question : IComparable, ICloneable
{
    public string Header { get; set; }
    public string Body { get; set; }
    public int Mark { get; set; }
    public Answer[] AnswerList { get; set; }
    public int RightAnswerId { get; set; }

    protected Question(string header, string body, int mark, Answer[] answers, int rightAnswerId)
    {
        Header = header;
        Body = body;
        Mark = mark;
        AnswerList = answers;
        RightAnswerId = rightAnswerId;
    }

    public abstract void DisplayQuestion();

    public int CompareTo(object obj)
    {
        if (obj is Question otherQuestion)
        {
            return Mark.CompareTo(otherQuestion.Mark);
        }
        throw new ArgumentException("Object is not a Question.");
    }

    public object Clone()
    {
      
        return MemberwiseClone();
    }

    public override string ToString() => $"{Header}: {Body} ({Mark} marks)";
}