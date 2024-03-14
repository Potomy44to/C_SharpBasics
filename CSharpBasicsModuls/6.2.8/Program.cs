class Rectangle
{
    public int a, b;

    public Rectangle()
    {
        a = 6;
        b = 4;
    }

    public Rectangle(int side)
    {
        a = side;
        b = side;
    }

    public Rectangle(int firstSide, int secondSide)
    {
        a = firstSide;
        b = secondSide;
    }

    public int Square()
    {
        return a * b;
    }
}