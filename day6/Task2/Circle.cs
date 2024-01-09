public class Circle
{
    private double Radius;
    public double radius { get{return Radius;} set{Radius = value;} }
    public Circle() {}
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public void SetRadius(double radius)
    {
        this.radius = radius;
    }
    public double GetRadius()
    {
        return radius;
    }
    public double GetArea()
    {
        return 2*3.14*Math.Pow(radius,2);
    }
    public double GetDiametr()
    {
        return 2*radius*2;
    }
    public double GetCircumference()
    {
        return 2*3.14*Math.Pow(radius,2);
    }
}