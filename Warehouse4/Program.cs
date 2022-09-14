// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
namespace Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Item eggs = new Item("eggs", 3, 3);
            Item bread = new Item("bread", 5, 6);

            Warehouse warehouse1 = new Warehouse(
                new List<Item> ()
                {
                    eggs,
                    bread,
                }
            );


            ShoppingTrip ShoppingTrip1 = new ShoppingTrip(
                new List<Item>()
                {
                    eggs,
                }
            );

            ShoppingTrip1.Checkout();

            foreach (Item item in warehouse1.GenerateReport())
            {
                Console.WriteLine(item.ItemNameGetter());
                Console.WriteLine(item.NumOfItemsGetter());
            }
        }
    }
}