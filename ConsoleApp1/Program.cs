

abstract class geographicObj
{
    double x, y;
    string name;
    string description;
    public geographicObj() { }
    public geographicObj (double x, double y, string name, string description)
    {
        this.x = x; this.y = y; this.name = name; this.description = description;
    }
}

class river : geographicObj
{
    double speed;
    double length;

}

class mountain : geographicObj
{
    double highestPoint;

}

class Program
{
    public static void Main(string[] args)
    {

    }
}
