using System.ComponentModel.DataAnnotations;

namespace AutoDealer.Models.VehicleComponents
{
    public class InteriorColor
    {   
        [Key]
        public Guid InteriorColorId { get; set; }
        public string? InteriorColorName { get; set; }
    }
}