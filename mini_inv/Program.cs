using System.Formats.Asn1;

Console.WriteLine("hello player this is the contents of your backpack.");

Character Char = new();
Weapon Axe = new() {Name = "Bloodied Axe", Weight = 10f};
Consumable HealingPotion = new() {Name = "Health Potion", Weight = 1f};

Char.Backpack.Items.Add(Axe);
Char.Backpack.Items.Add(HealingPotion);

Char.Backpack.display();


Armor Helmet = new() {Name = "Viking Helm", Weight = 5f};
Console.WriteLine($"On the Ground you see a {Helmet.Name} do you want to pick it up? (yes or no)");

bool answer = false;
while(answer == false)
{
string YesOrNo = Console.ReadLine().ToLower();
    
if (YesOrNo == "yes")
{
    Char.Backpack.Items.Add(Helmet);
    Console.WriteLine($"You have added {Helmet.Name} to your backpack. Wow so cool.");
    Console.WriteLine($"This is your inventory now.");
    answer = true;
}
else if (YesOrNo == "no")
{
    Console.WriteLine($"you do not pick up the {Helmet.Name}.");
    Console.WriteLine($"Really...");
    Console.WriteLine($"This is your inventory now.");   
    answer = true;
}
    else
    {
        Console.WriteLine("IT IS YES OR NO, VERY SIMPLE.");
    }
}

Char.Backpack.display();