
using RegisterAnimals.Entities;

namespace RegisterAnimals.Repositories;

public class AnimalRepository<T> where T : Animal
{
    private readonly List<Animal> animals = new List<T>();

    public AnimalRepository()
    {
        animals = new List<Animal>();
    }

    public void AddAnimal(T animal) 
    {
        if (animal == null)
            throw new ArgumentNullException(nameof(animal));

        animals.Add(animal);
    }

    public IEnumerable<Lion> GetLionCount()
    {
        return animals.OfType<Lion>();
    }

    public IEnumerable<Elephant> GetElephantCount()
    {
        return animals.OfType<Elephant>();
    }

    public int GetTotalAnimalCount()
    {
        return animals.Count;
    }
}