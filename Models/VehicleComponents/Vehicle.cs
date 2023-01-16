using AutoDealer.Models.Enums;

namespace AutoDealer.Models.VehicleComponents
{
    public class Vehicle
    {
        public string VehicleVIN { get; set; } = string.Empty;
        public TransmissionType Transmission { get; set; } = default!;
        public InteriorColorType InteriorColor { get; set; } = default!;
        public ExteriorColorType ExteriorColor { get; set; } = default!;
        public BodyStyleType BodyStyle { get; set; } = default!;
        public ModelType Model { get; set; } = default!;
        public decimal Mileage { get; set; }
    }
}