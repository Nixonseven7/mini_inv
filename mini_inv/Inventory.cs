public class Inventory
{
public List<Item> Items = [];
public void display()
    {
            Console.WriteLine("Inventory:");
        for (int i = 0; i < Items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Items[i].Name}");
            
        }
            Console.WriteLine("press enter to continue.");
            Console.ReadLine();
    }

}
