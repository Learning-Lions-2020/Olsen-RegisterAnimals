﻿// Base class for animals
public abstract class Animal
{
    public DateTime SightingTime { get; set; } // Example property for tracking
    protected Animal()
    {
        SightingTime = DateTime.Now;
    }
}

// Elephant subclass
public class Elephant : Animal
{
}

// Lion subclass
public class Lion : Animal
{
}

public class AnimalRepository
{
    private readonly List<Animal> _animals;

    public AnimalRepository()
    {
        _animals = new List<Animal>();
    }

    public void AddAnimal<T>(T animal) where T : Animal
    {
        if (animal == null)
            throw new ArgumentNullException(nameof(animal));

        _animals.Add(animal);
    }

    public IEnumerable<Lion> GetLionCount()
    {
        return _animals.OfType<Lion>();
    }

    public IEnumerable<Elephant> GetElephantCount()
    {
        return _animals.OfType<Elephant>();
    }

    public int GetTotalAnimalCount()
    {
        return _animals.Count;
    }
}