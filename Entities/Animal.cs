namespace RegisterAnimals.Entities;

public class Animal
{
    public string Type { get; set; }

    public Animal(string type)
    {
        Type = type;
    }
}