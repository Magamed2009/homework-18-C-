public class Rectangle
{
    public int Width;
    public int Height;
    public string Color;
    public int GetArea()
    {
        return Width*Height;
    }
    public int GetPerimeter()
    {
        return Width*Height*2;
    }
}