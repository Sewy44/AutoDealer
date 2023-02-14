using System.ComponentModel.DataAnnotations;

namespace AutoDealer.Models.VehicleComponents
{
    public class InteriorColorType
    {   
        [Key]
        public Guid InteriorColorId { get; set; }
        public string InteriorColorName { get; set; } = string.Empty;
    }
}