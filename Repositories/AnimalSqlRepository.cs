using Microsoft.EntityFrameworkCore;
using RegisterAnimals.Data;
using RegisterAnimals.Entities;

public class AnimalSqlRepository<T> where T : Animal
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
        int numberOfLions = _dbSet
            .OfType<Lion>()
            .Count();
        return numberOfLions;
    }

    public int GetElephantCount()
    {
        int numberOfElephants = _dbSet
            .OfType<Elephant>()
            .Count();
        return numberOfElephants;
    }
}