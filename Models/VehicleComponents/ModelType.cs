namespace AutoDealer.Models.VehicleComponents
{
    public class ModelType
    {
        public Guid ModelId { get; set; }
        public string ModelName { get; set; } = string.Empty;
        public BrandName Make { get; set; } = default!;
        public string AddedBy { get; set; } = string.Empty;
        public DateTime AddedDate { get; set; }
    }
}