using System.ComponentModel.DataAnnotations;

namespace AutoDealer.Models.VehicleComponents
{
    public class InteriorColor
    {   
        public Guid InteriorColorId { get; set; }
        public string InteriorColorName { get; set; }
    }
}