using System.ComponentModel.DataAnnotations;

namespace AutoDealer.Models.VehicleComponents
{
    public class Brand
    {
        [Key]
        public Guid BrandNameId { get; set; }
        public string? BrandName { get; set; }
        public DateTime AddedDate { get; set; }
        public string? AddedBy { get; set; }
    }
}