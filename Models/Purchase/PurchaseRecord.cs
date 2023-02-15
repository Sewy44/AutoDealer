﻿using AutoDealer.Models.Customer;
using AutoDealer.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoDealer.Models.Purchase
{
    public class PurchaseRecord
    {
        [Key]
        public Guid PurchaseId { get; set; }
        public PurchaseType TypeOfPurchase { get; set; }
        public Vehicle PurchasedVehicleRecord { get; set; } = default!;
        public CustomerRecord PurchasingCustomer { get; set; } = default!;
        public DateTime? PurchaseDate { get; set; }
        
        [Column(TypeName = "decimal(8,2)")]
        public decimal PurchasePrice { get; set; }
        public string SalesRepresentative { get; set; } = string.Empty;
    }
}
