namespace VendingMachine;

public class User
{
    public string Name { get; }
    public double Balance { get; set; }
    public Inventory UserInventory { get; private set; }
    public Bank UserBank { get; set; }

    public User(string name)
    {
        Name = name;
        Balance = 0;
        UserBank = new Bank();
        UserInventory = new Inventory();
    }
    
    public void WithdrawMoney(double amount)
    {
        UserBank.Balance -= amount;
        Balance += amount;
        Console.WriteLine($"You withdrew {amount}kr.");
        
    }

    public void CheckWallet()
    {
        Console.WriteLine($"You have {Balance}kr in your wallet.");
    }

}