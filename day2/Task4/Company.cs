public class Company
{
    public string CompanyName;
    public string Location;
    public string Ceo;
    public int NumberOfEmployees;
    public double Revenue;
    public List<Employee> Employee;
    public void HireEmployee(Employee employeeName)
    {
        Employee.Add(employeeName);
        NumberOfEmployees++;
    }
    public void FireEmployee(Employee employeeName)
    {
        foreach (var item in Employee)
        {
            System.Console.WriteLine(item + "\n");
        }
    }
    public string GenerateAnnualReport()
    {
        return $"Enter company name : {CompanyName}\nEnter company location : {Location}\nEnter CEO name : {Ceo}\nEnter number of employees : {NumberOfEmployees}\nRevenue : {Revenue}";
    }
}

public class Employee
{
    public string Name;
}