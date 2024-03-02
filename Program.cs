using System.Globalization;

Animals tiger = new Animals ("Tiger", "Asia", "Large");
Console.WriteLine (tiger.Name);
Console.WriteLine(tiger.Habitat);
Console.WriteLine (tiger.Size);
Console.WriteLine(tiger.ShowAnimal());
Console.ReadLine();
class Animals
{
    public string Name;     //Setting the properties of the class
    public string Habitat;
    public string Size;
    public DateTime DateTime;

    public Animals(string name, string habitat, string size) // Needed to create constructors
    {
        this.Name = name;
        this.Habitat = habitat;
        this.Size = size;
    }
    public string ShowAnimal()
=> $"Animal name is {Name}, Habitat is {Habitat}, Size is {Size}";
    /* int CalculateCircumference(){    How a method would work inside a class
     * return Width*Height;
     * } */

}
