using War.Units;

namespace War;


public class Army
{
    public List<Unit> Units = new List<Unit>();
    public int UnitCount => Units.Count;
    public bool IsALive => CheckAlive();


    public bool CheckAlive()
    {
        foreach (var unit in Units)
        {
            if (unit.IsALive)
            {
                return true;
            }
        }

        return false;
    }
    
    
    public void Show()
    {
        Console.WriteLine($"\nArmy damage: {GetDamageSum()} \nArmy health: {GetHealthsum()} \nArmy def: {GetDefSum()} \nUnits: " );
        ShowUnits();
    }
    public int GetDamageSum()
    {
        int damage=0;
        foreach (var unit  in Units)
        {
            damage = damage + unit.Damage;
        }

        return damage;
    }

    public int GetHealthsum()
    {
        int health = 0;
        foreach (var unit in Units)
        {
            health = health + unit.Health;
        }

        return health;
    }

    public int GetDefSum()
    {
        int def = 0;
        foreach (var unit in Units)
        {
            def = def + unit.Def;
        }

        return def;
    }

    private void ShowUnits()
    {
        foreach (var unit in Units)
        {
            unit.Show();
            
        }
    }

    public int Attack()
    {
        int attackSum = 0;
        foreach (var unit in Units)
        {
            attackSum += unit.Attack();
        }

        return attackSum;
    }
    
}