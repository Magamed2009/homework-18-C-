public class Student
{
    public int Id;
    public string Name;
    public int Age;
    public double Average;
    public Student(int id, string name, int age, double avarage)
    {
        Id = id;
        Name = name;
        Age = age;
        Average = avarage;
    }
    public void Getinfo()
    {
        System.Console.WriteLine($"Id : {Id}\nName : {Name}\nAge : {Age}\nAverage : {Average}");
    }
    public bool IsExcellentStudent()
    {
        if(Average > 4.0) {return true;}
        else {return false;}
    }
}