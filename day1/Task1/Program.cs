var person = new Person();
person.FirstName = Console.ReadLine();
person.LastName = Console.ReadLine();
person.Age = Convert.ToInt32(Console.ReadLine());

public class Person
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Getinfo()
    {
        return $"Name = {FirstName}\n Surname = {LastName}\n Age = {Age}";
    }
}