﻿using AutoDealer.Models.Enums;
using AutoDealer.Models.VehicleComponents;

namespace AutoDealer.Models
{
    public class VehicleRecord
    {
        public string VehicleVIN { get; set; } = string.Empty;
        public TransmissionType Transmission { get; set; } = default!;
        public InteriorColorType InteriorColor { get; set; } = default!;
        public ExteriorColorType ExteriorColor { get; set; } = default!;
        public BodyStyleType BodyStyle { get; set; } = default!;
        public ModelType Model { get; set; } = default!;
        public decimal Mileage { get; set; }
        public string Year { get; set; } = string.Empty;
        public DateTime DateAdded { get; set; }
        public string AddedBy { get; set; } = string.Empty;
        public decimal OriginalListPrice { get; set; }
        public decimal CurrentListPrice { get; set; }
        public decimal MRSP { get; set; }
        public string? Description { get; set; } = string.Empty;
        public string? ImageFileName { get; set; } = string.Empty;
        public bool IsFeatured { get; set; } = false;
        public bool IsUsed()
        {
            if (Mileage >= 1000)
            {
                return true;
            }
            return false;
        }

        public bool IsSold { get; set; } = false;
    }
}
