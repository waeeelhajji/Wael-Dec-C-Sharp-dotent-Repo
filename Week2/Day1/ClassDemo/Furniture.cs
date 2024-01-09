abstract class Furniture
{
    //! fields describe our object
    protected string color;
    public string _color { get { return color; } }
    private string materiel;
    public string _materiel { get { return materiel; } set { if (value != "Metal") { materiel = value; } } }
    public double price;
    public bool outdoor;
    //! Constructor
    public Furniture(string c, string m, double p, bool o)
    {
        color = c;
        materiel = m;
        price = p;
        outdoor = o;
    }
    public Furniture(string c, string m, double p)
    {
        color = c;
        materiel = m;
        price = p;
        outdoor = false;
    }

    //! Methods - what can our object do
    // Paint our Furniture
    public virtual void ChangeColor(string newColor)
    {
        Console.WriteLine($"Changed our furniture from {color} to {newColor}");
        color = newColor;

    }

}