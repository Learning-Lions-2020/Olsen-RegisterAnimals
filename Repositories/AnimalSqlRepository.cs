using Microsoft.EntityFrameworkCore;
using RegisterAnimals.Entities;

namespace RegisterAnimals.Data;

public class AnimalSqlRepository<T> : IAnimalRepository<T> where T : Animal
{
    private readonly AnimalDbContext _context;
    private readonly DbSet<Animal> _dbSet;

    public AnimalSqlRepository(AnimalDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = _context.Set<Animal>();
    }

    public void AddAnimal(T animal)
    {
        if (animal == null)
            throw new ArgumentNullException(nameof(animal));

        _dbSet.Add(animal);
        _context.SaveChanges();
    }

    public int GetLionCount()
    {
        return _dbSet.OfType<Lion>().Count();
    }

    public int GetElephantCount()
    {
        return _dbSet.OfType<Elephant>().Count();
    }

    public int GetTotalAnimalCount()
    {
        return _dbSet.Count();
    }
}