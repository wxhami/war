﻿namespace War.Units;

public abstract class Unit
{
    public int Health;
    public int Def;
    public UnitType Type;
    public int Damage;
    public bool IsALive => Health > 0;

  
    public virtual void Show()
    {
        Console.WriteLine($"health:\n{Health}  \ndef:{Def}  \ntype:{Type} \ndamage:{Damage}");
    }

    public virtual int Attack()
    {
        return Damage;
    }
}