using War.Items;

namespace War.Units;

public class Mechanism : Unit
{
    public Ammunition Ammunition;
    public int AmmunitionCount;

    public override int Attack()
    {
        if (AmmunitionCount <= 0)
        {
            return 0;
        }

        AmmunitionCount--;
        return Ammunition.Damage;
    }

    public override void Show()
    {
        Console.WriteLine($"health:\n{Health}  \ndef:{Def}  \ntype:{Type} \nAmmunition Count: {AmmunitionCount}");
    }
}