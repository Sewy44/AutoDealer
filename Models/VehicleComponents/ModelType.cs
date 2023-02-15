using System.ComponentModel.DataAnnotations;

namespace AutoDealer.Models.VehicleComponents
{
    public class ModelType
    {
        [Key]
        public Guid ModelId { get; set; }
        public string? Model { get; set; }
        public Brand? Brand { get; set; }
        public string? AddedBy { get; set; }
        public DateTime AddedDate { get; set; }

        public ModelType()
        {
            Brand Brand = new Brand();
        }
    }
}