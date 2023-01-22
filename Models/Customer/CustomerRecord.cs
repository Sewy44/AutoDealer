using AutoDealer.Models.Enums;

namespace AutoDealer.Models.Customer
{
    public class CustomerRecord
    {
        public Guid CustomerId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => FirstName + " " + LastName;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime AddedDate { get; set; }
        public string AddressLineOne { get; set; } = string.Empty;
        public string? AddressLineTwo { get; set; }
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public StateAbbreviation State { get; set; }

    }
}
