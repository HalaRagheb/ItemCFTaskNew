namespace Items.Entities
{
    public class MyItems:MainEntity
    {
        public string ItemName { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }

        public int Quantity { get; set; }

        public string Category {  get; set; }

        public string? Image { get; set; } 

    }
}
