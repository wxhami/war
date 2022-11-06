namespace War.Units;

public class Rider : Unit
{
    public Solder Solder;
    public Animal Animal;

    public Rider(Solder solder, Animal animal)
    {
        Solder = solder;
        Animal = animal;
        Health = Solder.Health + Animal.Health;
        Def = Solder.Def + Animal.Def;
        Damage = Solder.Damage + Animal.Damage;
    }

    public override void Show()
    {
        Console.WriteLine(
            $"health:\n{Health}  \ndef:{Def}  \ntype:{Type} \nDamage animal:{Animal.Damage} \nSolder damage: {Solder.Damage}");
    }
}