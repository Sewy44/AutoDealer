using System.ComponentModel.DataAnnotations;

namespace AutoDealer.Models.VehicleComponents
{
    public class Brand
    {
        public Guid BrandId { get; set; }
        public string BrandName { get; set; }
        public DateTime AddedDate { get; set; }
        public string? AddedBy { get; set; }
        public List<Model> Models { get; set; }

        public Brand()
        {
            Models = new List<Model>();
        }
    }
}