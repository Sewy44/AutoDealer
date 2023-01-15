namespace AutoDealer.Models
{
    public class ContactRequest
    {
        public Guid ContactRequestId { get; set; }
        public string? ContactFirstName { get; set; }
        public string? ContactLastName { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactPhone { get; set; }
        public string? ContactMessage { get; set; }
        public DateTime DateContactRequested { get; set; }
        public VehicleRecord? VehicleRequested { get; set; }
    }
}
