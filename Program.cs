using System.Globalization;

Animals tiger = new Animals ("Tiger", "Asia", "Large");
Console.WriteLine (tiger.ToString ());
Console.WriteLine (tiger.name);
Console.WriteLine(tiger.habitat);
Console.WriteLine (tiger.size);
Console.ReadLine ();

class Animals
{
    public string name;     //Setting the properties of the class
    public string habitat;
    public string size;
    public DateTime DateTime;

    public Animals(string name, string habitat, string size) // Needed to create constructors
    {
        this.name = name;
        this.habitat = habitat;
        this.size = size;
    }   
    /* int CalculateCircumference(){    How a method would work inside a class
     * return Width*Height;
     * } */
    
}
