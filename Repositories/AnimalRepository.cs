using RegisterAnimals.Entities;

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