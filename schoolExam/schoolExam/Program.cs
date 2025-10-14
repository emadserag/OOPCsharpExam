using schoolExam.mouduls;

// check in mouduls folder for all classes & display

// Create Subject

Subject SubjectCsharbBesic = new Subject(01, "Besic C#");

//create exam type True or False 
TrueOrFalseQuestion q1 = new TrueOrFalseQuestion("Q1", "Did Microsoft create the C# language?",10, 1);

//create list of answers for mcq question
Answer[] mcqAnswers = new Answer[]
{
            new Answer(1, "int"),
            new Answer(2, "string"),
            new Answer(3, "var")
};
QuestionMCQ q2 = new QuestionMCQ("Q2", "Which data type is a value type?", 10, mcqAnswers, 10);


Question[] finalExamQuestions = { q1, q2 };

// 3. إنشاء الامتحان النهائي وربطه بالمادة
FinalExam finalExam = new FinalExam(TimeSpan.FromMinutes(60), finalExamQuestions, SubjectCsharbBesic);
SubjectCsharbBesic.CreateSubjectExam(finalExam);

// 4. عرض الامتحان
finalExam.ShowExam();

// 5. تجربة الامتحان العملي
Subject sqlSubject = new Subject(102, "Database Queries");

Answer[] q2Answers = new Answer[]
{
            new Answer(1, "SELECT"),
            new Answer(2, "UPDATE"),
            new Answer(3, "CREATE")
};
QuestionMCQ practicalQ = new QuestionMCQ("Q2", "SQL command to retrieve data?", 15, q2Answers, 1); // 1=SELECT

Question[] practicalExamQuestions = { practicalQ };
PracticalExam practicalExam = new PracticalExam(TimeSpan.FromMinutes(30), practicalExamQuestions, sqlSubject);

sqlSubject.CreateSubjectExam(practicalExam);

// 6. عرض الامتحان العملي (سيعرض الإجابات الصحيحة)
practicalExam.ShowExam();
Console.WriteLine($"Q1 vs Q2 comparison: {q1.CompareTo(q2)} (Negative means Q1 < Q2)");

// ICloneable: نسخ Q2
QuestionMCQ q2Clone = (QuestionMCQ)q2.Clone();
q2Clone.Header = "Q2 (Cloned)";
Console.WriteLine($"Original Q2 Header: {q2.Header}");
Console.WriteLine($"Cloned Q2 Header: {q2Clone.Header}");
    



