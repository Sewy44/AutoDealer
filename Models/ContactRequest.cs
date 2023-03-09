using System.ComponentModel.DataAnnotations;

namespace AutoDealer.Models
{
    public class ContactRequest
    {
        [Key]
        public Guid ContactRequestId { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactFullName => ContactFirstName + " " + ContactLastName;
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMessage { get; set; }
        public DateTime DateContactRequested { get; set; }
        public virtual Vehicle VehicleRequested { get; set; }
        public string VehicleVIN { get; set; }
    }
}
