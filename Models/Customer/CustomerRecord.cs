using AutoDealer.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace AutoDealer.Models.Customer
{
    public class CustomerRecord
    {
        public Guid CustomerRecordId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        public string PhoneNumber { get; set; }
        public DateTime AddedDate { get; set; }
        public string AddressLineOne { get; set; }
        public string? AddressLineTwo { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public StateAbbreviation State { get; set; }
    }
}
