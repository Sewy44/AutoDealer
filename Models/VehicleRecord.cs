﻿using AutoDealer.Models.VehicleComponents;

namespace AutoDealer.Models
{
    public class VehicleRecord
    {
        public Guid VehicleRecordId { get; set; }
        public Vehicle? Vehicle { get; set; }
        public DateTime DateAdded { get; set; }
        public string? AddedBy { get; set; }
        public decimal OriginalListPrice { get; set; }
        public decimal CurrentListPrice { get; set; }
        public decimal MRSP { get; set; }
        public string? Description { get; set; }
        public string? ImageFileName { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsUsed()
        {
            if (Vehicle?.Mileage >= 1000)
            {
                return true;
            }
            return false;
        }

        public bool IsSold { get; set; }
    }
}
