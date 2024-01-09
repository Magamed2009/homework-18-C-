public class Author
{
    private string Name;
    private int Age;
    private string Nationality;
    public string name { get{return Name;} set{Name = value;} }
    public int age { get{return Age;} set{Age = value;} }
    public string nationality { get{return Nationality;} set{Nationality = value;} }
    public Author() {}
    public Author(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public Author(string name, int age, string nationality)
    {
         this.name = name;
        this.age = age;
        this.nationality = nationality;
    }
    public string GetName()
    {
        return $"{name}";
    }
    public int GetAge()
    {
        return age;
    }
    public string GetNationality()
    {
        return $"{nationality}";
    }
    public void Introduce()
    {
        System.Console.WriteLine($"My name is {name}. I am {age} years old. I am from {nationality}.");
    }
    public void CelebrateBirthday()
    {
        age++;
    }
}