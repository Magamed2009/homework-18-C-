public class User
{
    public string FirstName;
    public string LastName;
    public string UserName;
    public string Password;
    bool cnt = false; 
    public void Login(string username,string password)
    {
        if(UserName == username && Password == password) {cnt = true; System.Console.WriteLine($"User logged in successfully");}
        else {}System.Console.WriteLine("Your password or username is incorrect");
    }
    public void Logout()
    {
        cnt = false;
    }
    public string GetFullinfo()
    {
        return $"{FirstName}{LastName}{cnt}";
    }
}