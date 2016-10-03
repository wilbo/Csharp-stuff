class Vector
{
    private double _x;
    private double _y;

    public Vector(double x, double y)
    {
        _x = x;
        _y = y;
    }

    // define the operator '+' to be overloaded
    public static Vector operator +(Vector l, Vector r)
    {
        return new Vector( (l._x + r._x), (l._y + r._y) );
    }

    public override string ToString()
    {
        return "(" + _x + "," + _y + ")";
    }
}