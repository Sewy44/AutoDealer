using System.ComponentModel.DataAnnotations;

namespace AutoDealer.Models.VehicleComponents
{
    public class ExteriorColor
    {
        public Guid ExteriorColorId { get; set; }
        public string ExteriorColorName { get; set; }
    }
}