namespace Warehouse
{
    class Warehouse
    {
        List<Item> items;
        public Warehouse(List<Item> items)
        {
            this.items = items;
        }

        public List<Item> GenerateReport()
        {
            return this.items;
        }
    }
}