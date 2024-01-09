public class Order
{
    public int OrderNumber;
    public string ProductName;
    public int Quantity;
    public decimal TotalAmount;
    public Order(int orderNumber,string productName,int productQuantity,decimal orderAmount)
    {
        OrderNumber = orderNumber;
        ProductName = productName;
        Quantity = productQuantity;
        TotalAmount = orderAmount;
    }
    public Order(string productName,int productQuantity)
    {
        ProductName = productName;
        Quantity = productQuantity;
    }
    public Order(int orderNumber,decimal orderAmount)
    {
        OrderNumber = orderNumber;
        TotalAmount = orderAmount;
    }
    public void DisplayInfo() 
    {
        System.Console.WriteLine($"Number : {OrderNumber}\nProduct Name : {ProductName}\nQuantity : {Quantity}\nTotal Amount : {TotalAmount}");
    }
}