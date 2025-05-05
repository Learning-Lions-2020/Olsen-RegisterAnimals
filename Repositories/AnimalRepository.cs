using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using RegisterAnimals.Entities;

namespace RegisterAnimals.Data;

public class AnimalRepository : IAnimalRepository<Animal>, IEnumerable<Animal>, IEnumerable
{
    private readonly List<Animal> _animals;

    public AnimalRepository()
    {
        _animals = new List<Animal>();
    }

    public void AddAnimal(Animal animal)
    {
        if (animal == null)
            throw new ArgumentNullException(nameof(animal));

        _animals.Add(animal);
    }

    public int GetLionCount()
    {
        return _animals.OfType<Lion>().Count();
    }

    public int GetElephantCount()
    {
        return _animals.OfType<Elephant>().Count();
    }

    public int GetTotalAnimalCount()
    {
        return _animals.Count;
    }

    public List<Animal> GetAllAnimals()
    {
        return _animals.ToList();
    }

    public IEnumerator<Animal> GetEnumerator()
    {
        return _animals.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}