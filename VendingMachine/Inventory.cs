namespace VendingMachine;
using System.Collections.Generic;

public class Inventory
{
    private List<Item> items;

    public Inventory()
    {
        items = new List<Item>();
    }
    
    public Item GetItem(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            return items[index];
        }
        return null;
    }
    
    public bool AddUserItem(Item item, User user)
    {
        if (user.Balance < item.Price)
        {
            return false;
        }
        items.Add(item);
        user.Balance -= item.Price;
        return true;
        
    }
    
    public void DisplayUserInventory(User user)
    {
        var i = 0;
        Console.WriteLine($"{user.Name}'s Inventory:");
        foreach (Item item in items)
        {
            i++;
            Console.WriteLine($"[{i}] {item.Name} - {item.Price}kr");
        }
    }
    
    public void AddMachineItem(Item item)
    {
            items.Add(item);
    }
    
    public void DisplayMachineInventory()
    {
        Console.WriteLine("Vending Machine's Inventory:");
        var i = 0;
        foreach (Item item in items)
        {
            i++;
            Console.WriteLine($"[{i}] {item.Name} - {item.Price}kr");
        }
    }
    
}