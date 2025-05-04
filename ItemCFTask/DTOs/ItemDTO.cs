namespace Items.DTOs
{
    public class ItemDTO
    {
        public string ItemName { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }

        public int Quantity { get; set; }

        public string Category { get; set; }

        public string? ImageURL { get; set; } 
    }
}
