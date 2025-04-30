using RegisterAnimals.Entities;

namespace RegisterAnimals.Data;

public interface IAnimalRepository<T> where T : Animal
{
    void AddAnimal(T animal);
    int GetLionCount();
    int GetElephantCount();
    int GetTotalAnimalCount();
}