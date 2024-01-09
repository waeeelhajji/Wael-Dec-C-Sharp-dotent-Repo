class Chair : Furniture
{
    public int numLegs;
    public bool hasArms;


    //Constructor
    public Chair(string c, string m, double p, bool o, int n, bool h) : base(c, m, p, o)
    {
        numLegs = n;
        hasArms = h;

    }
    // Overriding

    public override void ChangeColor(string newColor)
    {
        Console.WriteLine($"Changed our chair from {color} to {newColor}");
        color = newColor;
        // base.ChangeColor(newColor);
    }




}