using RegisterAnimals.Entities;

namespace RegisterAnimals.Repositories;

public class AnimalRepository<T> where T : Animal
{
    private readonly List<T> animals = new List<T>();

    public void AddAnimal(T animal)
    {
        animals.Add(animal);
    }

    public List<Lion> GetLionCount()
    {
        return animals.OfType<Lion>().ToList();
    }

    public List<Elephant> GetElephantCount()
    {
        return animals.OfType<Elephant>().ToList();
    }

    public int GetTotalAnimalCount()
    {
        return animals.Count;
    }
}