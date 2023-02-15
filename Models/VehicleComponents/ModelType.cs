using System.ComponentModel.DataAnnotations;

namespace AutoDealer.Models.VehicleComponents
{
    public class ModelType
    {
        [Key]
        public Guid ModelId { get; set; }
        public string? Model { get; set; }
        public Brand? BrandName { get; set; }
        public string? AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
    }
}