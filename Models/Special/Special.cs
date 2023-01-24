namespace AutoDealer.Models.Special
{
    public class Special
    {
        public Guid SpecialId { get; set; }
        public string SpecialName { get; set; } = string.Empty;
        public string SpecialDescription { get; set; } = string.Empty;
        public string AddedBy { get; set; } = string.Empty;
        public DateTime AddedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string ImageFileName { get; set; } = string.Empty;
    }
}
