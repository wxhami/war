using War.Units;

namespace War;

public class War
{
    public Army OpponentArmy;
    private ArmyBuilder armyBuilder = new ArmyBuilder();
    int weight = 0;
    public Army PlayerArmy;

    public War(Army playerArmy)
    {
        OpponentArmy = CreateArmy();
        PlayerArmy = playerArmy;
    }

    private Army CreateArmy()
    {
        while (weight <= 20)
        {
            armyBuilder.AddAnimal();
            weight += 2;

            armyBuilder.AddMechanism();
            weight += 4;

            armyBuilder.AddSolder();
            weight += 1;

            armyBuilder.AddRider();
            weight += 3;
        }

        return armyBuilder.Build();
    }


    public Army Play()
    {
        int PlayerDef = PlayerArmy.GetDefSum();
        int opponentDef = OpponentArmy.GetDefSum();

        while (OpponentArmy.CheckAlive() && PlayerArmy.CheckAlive())
        {
            int playerDamage = PlayerArmy.GetDamageSum();

            playerDamage = playerDamage - opponentDef;

            foreach (var unit in OpponentArmy.Units)
            {
                int damage = playerDamage - unit.Health;

                if (damage <= 0)
                {
                    unit.Health = unit.Health - playerDamage;
                    playerDamage = 0;
                    break;
                }

                playerDamage = playerDamage - unit.Health;
                unit.Health = 0;
            }
            
            int opponentDamage = OpponentArmy.GetDamageSum();

            foreach (var unit in PlayerArmy.Units)
            {
                int damage = opponentDamage - unit.Health;

                if (damage <= 0)
                {
                    unit.Health = unit.Health - opponentDamage;
                    opponentDamage = 0;
                    break;
                }

                opponentDamage = opponentDamage - unit.Health;
                unit.Health = 0;
            }
        }

        if (PlayerArmy.CheckAlive())
        {
            return PlayerArmy;
        }
        else if (OpponentArmy.CheckAlive())
        {
            return OpponentArmy;
        }

        return null;
    }
}