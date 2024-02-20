using VendingMachine;

Console.Write("Please type your name: ");
var name = Console.ReadLine();
var user = new User(name);
var machine = new Machine();
Console.Clear();
Console.WriteLine($"Hello {name}, Welcome to the");
Console.WriteLine("Fantastic Vending Machine!");
Console.WriteLine("Press any key to continue...");

Menu();

void Menu()
{
    var input = false;
    while (!input)
    {
        Console.Clear();
        Console.WriteLine("Fantastic Vending Machine!");
        Console.WriteLine("**************************");
        Console.WriteLine("Choose any option below");
        Console.WriteLine("[1] Check the Vending Machine");
        Console.WriteLine("[2] Check your balance");
        Console.WriteLine("[3] Check your inventory");
        Console.WriteLine("[X] To exit");
        Console.Write("Option: ");
        var option = Console.ReadKey().Key;

        
        switch (option)
        {
            case ConsoleKey.D1:
                Console.Clear();
                machine.MachineInventory.DisplayMachineInventory();
                BuyItem();
                break;
            case ConsoleKey.D2:
                Console.Clear();
                user.CheckBalance();
                input = BackToMenu();
                break;
            case ConsoleKey.D3:
                Console.Clear();
                user.UserInventory.DisplayUserInventory(user);
                input = BackToMenu();
                break;
            case ConsoleKey.X:
                input = true;
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.WriteLine("Not an valid option... ");
                BackToMenu();
                break;
        }
    }
}

bool BackToMenu()
{
    Console.WriteLine("Back to menu? Press 'M' or any key to exit.");
    var backToMenuKey = Console.ReadKey().Key;
    return backToMenuKey != ConsoleKey.M;
}

void BuyItem()
{
    Console.WriteLine("Press any of the above numbers to purchase an item.");
    Console.Write("> ");
    
    var option = Console.ReadKey().Key;
    
    switch (option)
    {
        case ConsoleKey.D1:
            var item = machine.MachineInventory.GetItem(0);
            var add = user.UserInventory.AddUserItem(item, user);
            if (add)
            {
                Console.Clear();
                Console.WriteLine(item.Name + " was purchased, enjoy!");
                
                //use item test
                Console.WriteLine($"Would you like to use {item.Name}?y/n");
                var answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("Aaaah.. How refreshing!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sorry but you don't have enough credits!");
                Console.ReadLine();
            }
            break;
        case ConsoleKey.D2:
            user.UserInventory.AddUserItem(machine.MachineInventory.GetItem(1), user);
            break;
        case ConsoleKey.D3:
            user.UserInventory.AddUserItem(machine.MachineInventory.GetItem(2), user);
            break;
        case ConsoleKey.D4:
            user.UserInventory.AddUserItem(machine.MachineInventory.GetItem(3), user);
            break;
    }
}

void AddCredits()
{
    
}