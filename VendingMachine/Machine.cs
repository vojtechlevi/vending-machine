namespace VendingMachine;

public class Machine
{
    public Inventory MachineInventory { get; }

    public Machine()
    {
        MachineInventory = new Inventory();
        MachineInventory.AddMachineItem(new Item("Nocco Grand Sour 33cl", 25));
        MachineInventory.AddMachineItem(new Item("Coca-Cola Zero 33cl", 10));
        MachineInventory.AddMachineItem(new Item("Ramlösa Citron 33cl", 10));
        MachineInventory.AddMachineItem(new Item("Ramlösa Naturell 33cl", 10));
    }
}