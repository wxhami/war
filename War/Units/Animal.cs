namespace War.Units;

public class Animal: Unit
{
    public Animal()
    {
        Health = 100;
        Damage = 50;
        Def = 20;
        Type = UnitType.Animal;
    }
}