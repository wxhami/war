using War.Items;

namespace War.Units;

public class Solder: Unit
{
    public Armor Armor;

    public override void Show()
    {
        Console.WriteLine($"health:\n{Health}  \ndef:{Def}  \ntype:{Type} \nArmor name: {Armor.Name} \nArmor: {Armor.Def}");
    }
}