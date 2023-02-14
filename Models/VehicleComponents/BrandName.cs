using System.ComponentModel.DataAnnotations;

namespace AutoDealer.Models.VehicleComponents
{
    public class BrandName
    {
        [Key]
        public Guid BrandNameId { get; set; }
        public string MakeName { get; set; } = string.Empty;
        public DateTime AddedDate { get; set; }
        public string AddedBy { get; set; } = string.Empty;
    }
}