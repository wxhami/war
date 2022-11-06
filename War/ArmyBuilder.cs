using War.Items;
using War.Units;

namespace War;

public class ArmyBuilder
{
    private Army army;

    public ArmyBuilder()
    {
        army = new Army();
    }
    
    public void AddRider()
    {
        Solder solder = CreateSolder();
        Animal animal = new Animal();
        Rider rider = new Rider(solder, animal);
        army.Units.Add(rider);
    }

    public void AddSolder()
    {
        army.Units.Add(CreateSolder());
        
    }

    public void AddMechanism()
    {
       int ammutionCount = new Random().Next(8, 12);
       int damage = new Random().Next(40, 50);
       Ammunition ammunition = new Ammunition(damage);
       Mechanism mechanism = new Mechanism(ammunition, ammutionCount);
       army.Units.Add(mechanism);
        
    }

    public void AddAnimal()
    {
       Unit animal = new Animal();
       army.Units.Add(animal);
    }

    private Solder CreateSolder()
    {
        Random random = new Random();
        int randomEnd = random.Next(40, 50);
        
        Armor armor = new Armor(randomEnd);
        Solder solder = new Solder(armor);

        return solder;
    }
}