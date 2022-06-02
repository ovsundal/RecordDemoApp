using System.Threading.Channels;

Record1 r1a = new("Tim", "Corey");
Record1 r1b = new("Tim", "Corey");
Record1 r1c = new("Sue", "Storm");

Class1 c1a = new("Tim", "Corey");
Class1 c1b = new("Tim", "Corey");
Class1 c1c = new("Sue", "Storm");

Console.WriteLine("Record Type:");
Console.WriteLine($"To String: {r1a}");
Console.WriteLine($"Are the two objects equal: {Equals(r1a, r1b)}");
Console.WriteLine($"Are the two objects reference equal: {ReferenceEquals(r1a, r1b)}");
Console.WriteLine($"Are the two objects ==: {r1a == r1b}");
Console.WriteLine($"Are the two objects !=: {r1a != r1c}");
Console.WriteLine($"Hash code of object A: {r1a.GetHashCode()}");
Console.WriteLine($"Hash code of object B: {r1b.GetHashCode()}");
Console.WriteLine($"Hash code of object C: {r1c.GetHashCode()}");

Console.WriteLine();
Console.WriteLine("******************");
Console.WriteLine();

Console.WriteLine("Class Type:");
Console.WriteLine($"To String: {c1a}");
Console.WriteLine($"Are the two objects equal: {Equals(c1a, c1b)}");
Console.WriteLine($"Are the two objects reference equal: {ReferenceEquals(r1a, r1b)}");
Console.WriteLine($"Are the two objects ==: {c1a == c1b}");
Console.WriteLine($"Are the two objects !=: {c1a != c1c}");
Console.WriteLine($"Hash code of object A: {c1a.GetHashCode()}");
Console.WriteLine($"Hash code of object B: {c1b.GetHashCode()}");
Console.WriteLine($"Hash code of object C: {c1c.GetHashCode()}");

Console.WriteLine();

var (fn, ln) = r1a;
Console.WriteLine($"The value of fn is {fn} and the value of ln is {ln}");

// copy record with new values
Record1 r1d = r1a with
{
    FirstName = "Jon"
};

Console.WriteLine($"Jon's record: {r1d}");

// a Record is just a fancy class
// Immutable - The values cannot be changed
public record Record1(string FirstName, string LastName);

public class Class1
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public Class1(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void Deconstruct(out string FirstName, out string LastName)
    {
        FirstName = this.FirstName;
        LastName = this.LastName;
    }
}
// https://www.youtube.com/watch?v=9Byvwa9yF-I
// 36:17