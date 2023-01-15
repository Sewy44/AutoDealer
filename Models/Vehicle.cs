namespace AutoDealer.Models
{
    public class Vehicle
    {
        public Guid VehicleId { get; set; }
        public TransmissionType? Transmission { get; set; }
        public InteriorColorType? InteriorColor { get; set; }
        public ExteriorColorType? ExteriorColor { get; set; }
        public BodyStyleType? BodyStyle { get; set; }
        public ModelType? Model { get; set; }
        public decimal Mileage { get; set; }
    }
}