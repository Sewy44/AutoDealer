using AutoDealer.Models.Customer;
using AutoDealer.Models.Enums;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class MockCustomerRecordRepository : ICustomerRecordRepository
    {
        private List<CustomerRecord> _customerRecords = new List<CustomerRecord>();
        public IEnumerable<CustomerRecord> GetAll() =>
            new List<CustomerRecord>
            {
                new CustomerRecord
                {
                    CustomerId = Guid.NewGuid() ,
                    FirstName = "Jim",
                    LastName = "Jimerson",
                    PhoneNumber = "502-555-5555",
                    AddedDate = DateTime.Now,
                    AddressLineOne = "555 5th Street",
                    Email = "Jim@jim.com",
                    City = "Louisville",
                    ZipCode = "40444",
                    State = StateAbbreviation.KY
                },
                new CustomerRecord
                {
                    CustomerId = Guid.NewGuid() ,
                    FirstName = "Tom",
                    LastName = "Thomson",
                    PhoneNumber = "502-555-4444",
                    AddedDate = DateTime.Now,
                    AddressLineOne = "Tomson St.",
                    Email = "Tom@tom.com",
                    City = "Columbus",
                    ZipCode = "40000",
                    State = StateAbbreviation.OH
                }
            };

        public void InsertCustomerRecord(CustomerRecord customerRecord)
        {
            _customerRecords.Add(customerRecord);
        }
    }
}
