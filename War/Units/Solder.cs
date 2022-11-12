using War.Items;

namespace War.Units;

public class Solder: Unit
{
    public Armor Armor;

    public Solder(Armor armor)
    {
        Armor = armor;
        Health = 50;
        Def = 10 + armor.Def;
        Damage = 80;
        Type = UnitType.Solder;
    }
    public override void Show()
    {
        Console.WriteLine($"health:\n{Health}  \ndef:{Def}  \ntype:{Type} \nArmor name: {Armor.Name} \nArmor: {Armor.Def}");
    }
}