
using Microsoft.VisualBasic;

interface IGeographicObj
{
    public void information(double x, double y, string name, string description);
}
class river : IGeographicObj
{
    double x;
    double y;
    string name;
    string description;
    double speed;
    double length;
    public void information(double x, double y, string name, string description)
        {
            this.x = x;
            this.y = y;
            this.name = name;
            this.description = description;
        }
}

class mountain : IGeographicObj
{
    double x;
    double y;
    string name;
    string description;
    double highestPoint;
    public void information(double x, double y, string name, string description)
    {
        this.x = x;
        this.y = y;
        this.name = name;
        this.description = description;
    }
}

class Program
{
    public static void Main(string[] args)
    {

    }
}

