namespace VendingMachine;

public class User
{
    public string Name { get; }
    public double Balance { get; set; }
    public Inventory UserInventory { get; private set; }

    public User(string name)
    {
        Name = name;
        Balance = 100;
        UserInventory = new Inventory();
        
    }
    
    
    public void InsertMoney(double amount)
    {
        Balance += amount;
        Console.WriteLine($"You inserted {amount}kr. Current balance: {Balance}kr");
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current Balance: {Balance}kr");
    }

}