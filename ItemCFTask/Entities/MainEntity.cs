namespace Items.Entities
{
    public class MainEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string? UpdateBy { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; }


    }
}
