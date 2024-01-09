public class User
{
    public string FirstName;
    public string LastName;
    public string UserName;
    private string Password;
    public string password { get{return Password;} set{Password = value;} }
    public User(string firstName, string lastName, string userName, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        UserName = userName;
        this.password = password;
    }
    public void Getinfo()
    {
        System.Console.WriteLine($"Name : {FirstName}\nLastName : {LastName}\nUsername : {UserName}\nPassword : {password}");
    }
    public void Login(string userName, string password)
    {
        if(UserName == userName && this.Password == password) {System.Console.WriteLine($"Login successful! Welcome, Mr./Ms. {FirstName} {LastName}");}
        else {System.Console.WriteLine("Login failed!.");}
    }
}