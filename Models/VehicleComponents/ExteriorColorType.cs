using System.ComponentModel.DataAnnotations;

namespace AutoDealer.Models.VehicleComponents
{
    public class ExteriorColorType
    {
        [Key]
        public Guid ExteriorColorId { get; set; }
        public string ExteriorColorName { get; set; } = string.Empty;
    }
}