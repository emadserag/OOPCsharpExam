
namespace schoolExam.mouduls;

public class Answer
{
   public int Id { get; set; }
   public string? TextAnserwer { get; set; }


public Answer(int idAnserwer, string textAnserwer)
   {
      Id = Id;
      TextAnserwer = textAnserwer;
    }
    public override string ToString()
    {
        return $"Answer id : {Id} \n Answer : {TextAnserwer} ";
    }
}
