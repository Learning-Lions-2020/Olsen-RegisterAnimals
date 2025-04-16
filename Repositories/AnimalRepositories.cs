public class AnimalRepository
{
    private int _elephantCount;
    private int _lionCount;

    public AnimalRepository()
    {
        _elephantCount = 0;
        _lionCount = 0;

    }

    public void AddElephant()
    {
        _elephantCount++;
    }

    public void AddLion()
    {
        _lionCount++;
    }

    public int GetElephantCount()
    {
        return _elephantCount;
    }

    public int GetLionCount()
    {
        return _lionCount;
    }

    public int GetTotalAnimalCount()
    {
        return _elephantCount + _lionCount;
    }
}