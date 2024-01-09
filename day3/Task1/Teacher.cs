public class Teacher
{
    private string FullName;
    private string Subject;
    private int Experience;

    public string fullName { get{return FullName;} set{FullName = value;} }
    public string subject { get{return Subject;} set{Subject = value;} }
    public int experience { get{return Experience;} set{Experience = value;} }
    public Teacher() {}
    public Teacher(string name,string subject)
    {
        fullName = name;
        this.subject = subject; 
    }
    public Teacher(string name,string subject,int experience)
    {
        fullName = name; 
        this.subject = subject;
        this.experience = experience;       
    }
    public string Teach()
    {
        return $"{fullName} is teaching {subject}";
    }
    public void SetExperience(int years) 
    {
        experience = years;
    }
    public int GetExperience()
    {
        return experience;
    } 
}