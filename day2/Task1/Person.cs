public class Person
{
    public string FirstName;
    public string LastName;
    public int Age;
    public int Address;
    public string GetFullName()
    {
        return $"Name : {FirstName}\nLastName : {LastName}";
    }
    public int GetBirthDay()
    {
        return 2023-Age;
    }
}