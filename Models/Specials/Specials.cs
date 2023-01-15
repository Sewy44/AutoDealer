namespace AutoDealer.Models.Specials
{
    public class Specials
    {
        public Guid SpecialId { get; set; }
        public string? SpecialName { get; set; }
        public string? SpecialDescription { get; set; }
        public string? AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
