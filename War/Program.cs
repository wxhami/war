using War;

int PlayerChoice = 0;
ArmyBuilder armyBuilder = new ArmyBuilder();
int weight = 0;
Army army;
PlayerChoice = Convert.ToInt32(Console.ReadLine());

while (weight <= 20)
{
    Console.WriteLine(
        "Choose action:  \n1 - Create Animal \n2 -  Create rider \n3 - Create solder \n4 - Create mechanism");
    switch (PlayerChoice)
    {

        case 1:
            armyBuilder.AddAnimal();
            break;

        case 2:
            armyBuilder.AddRider();
            break;

        case 3:
            armyBuilder.AddSolder();
            break;

        case 4:
            armyBuilder.AddMechanism();
            break;
    }
}

army = armyBuilder.Build();

Console.WriteLine("Choose action: \n5- Show army \n6 - War \n7 - Shut down ");
if (PlayerChoice == 1)
{
    army.Show();
}