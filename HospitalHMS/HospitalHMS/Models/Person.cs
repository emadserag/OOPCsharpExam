// set gender property to public
using HospitalHMS.Models;

/// <summary>
/// Initializes a new instance of the <see cref="Person"/> class with the specified identifier, name, age, and
/// gender.
/// </summary>
/// <param name="id">The unique identifier for the person. Cannot be null or empty.</param>
/// <param name="name">The name of the person. Cannot be null or empty.</param>
/// <param name="age">The age of the person. Must be greater than 0.</param>
/// <param name="gender">The gender of the person.</param>
public enum Gender {male,female };
public abstract class Person
{
    public string Id { get; protected set; }
    public string Name { get; protected set; }
    public int Age { get; protected set; }
    public Gender Gender { get; protected set; } 
    public Person(string id, string name, int age, Gender gender)
    {
        if (age <= 0)
        {
            Console.WriteLine("the age not vaild");
        }

        Id = id;
        Name = name;
        Age = age;
        Gender = gender;
    }
    public abstract void DisplayInfo();
    public virtual string GetRole()
    {
        return "Person";
    }

}