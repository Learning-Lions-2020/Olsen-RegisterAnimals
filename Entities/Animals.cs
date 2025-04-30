using System;

namespace RegisterAnimals.Entities;

public abstract class Animal
{
    public int Id { get; set; } 
    public DateTime SightingTime { get; set; }
    protected Animal()
    {
        SightingTime = DateTime.Now;
    }
}



