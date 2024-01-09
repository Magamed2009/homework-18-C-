public class Actor
{
    private string FullName;
    private int Age;
    private string Gender;
    private List<string> moviesPlayed;
    public string fullName { get{return FullName;} set{FullName = value;} }
    public int age{ get{return Age;} set{Age = value;} }
    public string gender { get{return Gender;} set{Gender = value;} }
    public Actor() {}
    public Actor(string fullName,int age,string gender)
    {
        this.fullName = fullName;
        this.age = age;
        this.gender = gender;
    }
    public void AddMoviesPlayed(string movieTitle)
    {
        moviesPlayed.Add(movieTitle);
    }
    public void SetAge(int age)
    {
        this.age = age;
    } 
    public int GetAge()
    {
        return age;
    }
    public void SetGender(string gender)
    {
        this.gender = gender;
    }
    public string GetGender()
    {
        return $"{gender}";
    }
}