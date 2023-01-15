namespace AutoDealer.Models.VehicleComponents
{
    public class ModelType
    {
        public Guid ModelId { get; set; }
        public string? ModelName { get; set; }
        public BrandName? Make { get; set; }
        public string? AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
    }
}