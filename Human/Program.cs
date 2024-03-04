// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
namespace Human
{
    class Program
    {
    // Properties for Human
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }
    private int Health { get; set; }

    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Program(){
        Name ="Tom";
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }

    // Add a constructor to assign custom values to all fields
    public Program(string name, int strength, int intell, int dex, int health){
        Name = name;
        Strength = strength;
        Intelligence = intell;
        Dexterity = dex;
        Health = health;
    }

    // Build Attack method
    public int Attack(Program target){
          int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
    }
    }
}
