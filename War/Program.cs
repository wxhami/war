using War;

int playerChoice = 0;
ArmyBuilder armyBuilder = new ArmyBuilder();
int weight = 0;
Army army;
bool shutDawn = true;


while (weight <= 20)
{
    Console.WriteLine(
        "Choose action:  \n1 - Create Animal \n2 -  Create rider \n3 - Create solder \n4 - Create mechanism");
    playerChoice = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    switch (playerChoice)
    {
        case 1:
            armyBuilder.AddAnimal();
            weight += 2;
            break;

        case 2:
            armyBuilder.AddRider();
            weight += 3;
            break;

        case 3:
            armyBuilder.AddSolder();
            weight += 1;
            break;

        case 4:
            armyBuilder.AddMechanism();
            weight += 4;
            break;
    }
}
Console.Clear();
Console.WriteLine("Your army ready to war");


army = armyBuilder.Build();
War.War war = new War.War(army);
while (shutDawn)
{
    Console.WriteLine("Choose action: \n1- Show army \n2 - War \n3 - Shut down ");
    playerChoice = Convert.ToInt32(Console.ReadLine());
Console.Clear();
    switch (playerChoice)
    {
        case 1:
            army.Show();
            break;

        case 2:
            Console.WriteLine(war.Play());
            Thread.Sleep(5000);
            shutDawn = false;
            break;

        case 3:
            shutDawn = false;
            break;
    }
}