namespace Warehouse
{
    class ShoppingTrip
    {
        List<Item> items;
        
        public ShoppingTrip(List<Item> items)
        {
            this.items = items;
        }
        
        public void Checkout()
        {
            foreach (Item item in items)
            {
                item.SellItem(item.NumOfItemsGetter());
            }

        }
    }
}