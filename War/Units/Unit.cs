namespace War.Units;

public abstract class Unit
{
    public int health;
    public int def;
    public UnitType type;
    public int damage;

    public virtual void Show()
    {
        Console.WriteLine($"health:\n{health}  \ndef:{def}  \ntype:{type}");
    }

    public virtual int Attack()
    {
        return damage;
    }
}