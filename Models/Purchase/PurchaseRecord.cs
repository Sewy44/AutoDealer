using AutoDealer.Models.Customer;
using AutoDealer.Models.Enums;

namespace AutoDealer.Models.Purchase
{
    public class PurchaseRecord
    {
        public Guid PurchaseId { get; set; }
        public PurchaseType TypeOfPurchase { get; set; }
        public VehicleRecord PurchasedVehicleRecord { get; set; } = default!;
        public CustomerRecord PurchasingCustomer { get; set; } = default!;
        public DateTime? PurchaseDate { get; set; }
        public decimal PurchasePrice { get; set; }
        public string SalesRepresentative { get; set; } = string.Empty;

    }
}
