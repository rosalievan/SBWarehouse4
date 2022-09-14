namespace Warehouse
{
    class Item
    {
        String ItemName;
        Decimal ItemPrice;

        int NumOfItems;
        public Item(String ItemName, int NumOfItems, Decimal ItemPrice)
        {
            this.ItemName = ItemName;
            this.ItemPrice = ItemPrice;
            this.NumOfItems = NumOfItems;
        }

        public String ItemNameGetter()
        {
            return ItemName;
        }

        public Decimal ItemPriceGetter()
        {
            return ItemPrice;
        }

        public int NumOfItemsGetter()
        {
            return NumOfItems;
        }

        public void SellItem(int ItemsSold)
        {
            NumOfItems -= ItemsSold;
        }
    }
}