using AutoDealer.Models.Enums;
using AutoDealer.Models.VehicleComponents;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoDealer.Models
{
    public class VehicleRecord
    {
        [Key]
        public string VehicleVIN { get; set; } = string.Empty;
        public TransmissionType Transmission { get; set; } = default!;
        public InteriorColorType InteriorColor { get; set; } = default!;
        public ExteriorColorType ExteriorColor { get; set; } = default!;
        public BodyStyleType BodyStyle { get; set; } = default!;
        public ModelType Model { get; set; } = default!;
        
        [Column(TypeName = "decimal(6,0)")]
        public decimal Mileage { get; set; }
        public string Year { get; set; } = string.Empty;
        public DateTime DateAdded { get; set; }
        public string AddedBy { get; set; } = string.Empty;
        
        [Column(TypeName = "decimal(8,2)")]
        public decimal OriginalListPrice { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal CurrentListPrice { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal MRSP { get; set; }
        public string? Description { get; set; } = string.Empty;
        public bool IsFeatured { get; set; } = false;
        public bool IsSold { get; set; } = false;
        public bool IsUsed { get; set; } = false;

        public string ImageFileName 
        { 
            get => "inventory-" + VehicleVIN + ".jpg";
            set => ImageFileName = value; 
        }
    }
}
