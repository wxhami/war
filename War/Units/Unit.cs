namespace War.Units;

public abstract class Unit
{
    public int Health;
    public int Def;
    public UnitType Type;
    public int Damage;

    public virtual void Show()
    {
        Console.WriteLine($"health:\n{Health}  \ndef:{Def}  \ntype:{Type}");
    }

    public virtual int Attack()
    {
        return Damage;
    }
}