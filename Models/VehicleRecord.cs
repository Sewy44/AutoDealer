using AutoDealer.Models.VehicleComponents;

namespace AutoDealer.Models
{
    public class VehicleRecord
    {
        public Guid VehicleRecordId { get; set; }
        public Vehicle Vehicle { get; set; } = default!;
        public DateTime DateAdded { get; set; }
        public string AddedBy { get; set; } = string.Empty;
        public decimal OriginalListPrice { get; set; }
        public decimal CurrentListPrice { get; set; }
        public decimal MRSP { get; set; }
        public string? Description { get; set; } = string.Empty;
        public string? ImageFileName { get; set; } = string.Empty;
        public bool IsFeatured { get; set; }
        public bool IsUsed()
        {
            if (Vehicle.Mileage >= 1000)
            {
                return true;
            }
            return false;
        }

        public bool IsSold { get; set; }
    }
}
