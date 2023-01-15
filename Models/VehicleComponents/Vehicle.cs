using AutoDealer.Models.Enums;

namespace AutoDealer.Models.VehicleComponents
{
    public class Vehicle
    {
        public string? VehicleVIN { get; set; }
        public TransmissionType? Transmission { get; set; }
        public InteriorColorType? InteriorColor { get; set; }
        public ExteriorColorType? ExteriorColor { get; set; }
        public BodyStyleType? BodyStyle { get; set; }
        public ModelType? Model { get; set; }
        public decimal Mileage { get; set; }
    }
}