using System.ComponentModel.DataAnnotations;

namespace AutoDealer.Models.VehicleComponents
{
    public class Model
    {
        public Guid ModelId { get; set; }
        public string ModelName { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public Brand BrandName { get; set; }
        public Guid BrandNameId { get; set; } 
    }
}