using AutoDealer.Models.Customer;
using AutoDealer.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoDealer.Models.Purchase
{
    public class PurchaseRecord
    {
        public Guid PurchaseRecordId { get; set; }
        public PurchaseType TypeOfPurchase { get; set; }
        public DateTime PurchaseDate { get; set; }
        
        [Column(TypeName = "decimal(8,2)")]
        public decimal PurchasePrice { get; set; }
        public string SalesRepresentative { get; set; }
        public Vehicle PurchasedVehicleRecord { get; set; }
        public string VehicleVIN { get; set; }
        public CustomerRecord PurchasingCustomer { get; set; }
        public Guid CustomerId { get; set; }
    }
}
