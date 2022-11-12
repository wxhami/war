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

    public Mechanism(Ammunition ammunition, int ammunitionCount)
    {
        Ammunition = ammunition;
        AmmunitionCount = ammunitionCount;
        Health = 150;
        Type = UnitType.Mechanism;

    }
    public override void Show()
    {
        Console.WriteLine($"type:{Type} \nhealth:\n{Health}  \ndef:{Def}  \nAmmunition Count: {AmmunitionCount}\n \tAmmunition Damage: {Ammunition.Damage}\n\tAmmunition Name: {Ammunition.Name} \n");
    }
}