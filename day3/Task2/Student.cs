public class Student
{
    private string FullName;
    private int Age;
    private int Grade;
    public string fullName { get{return FullName;} set{FullName = value;} }
    public int age { get{return Age;} set{Age = value;} }
    public int grade { get{return Grade;} set{Grade = value;} }
    public Student() {}
    public Student(string name,int age)
    {
        fullName = name;
        this.age = age;
    }
    public Student(string name,int age,int grade)
    {
        fullName = name;
        this.age = age;
        this.grade = grade;
    }
    public void Study()
    {
        System.Console.WriteLine($"{fullName} is studying");
    }
    public void SetGrade(int newGrade)
    {
        grade = newGrade;
    }
    public int GetGrade()
    {
        return grade;
    }
}