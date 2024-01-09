public class Employee
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Position;
    public decimal Salary;
    public void SetSalary(decimal salary)
    {
        Salary = salary;
    }   
    public decimal GetSalary()
    {
        return Salary;
    }
    public string Getinfo()
    {
        return $"Name : {FirstName}\nLastName : {LastName}\nAge : {Age}\nPosition : {Position}\nSalary : {Salary}";
    }
}