using AutoDealer.Models.Customer;
using AutoDealer.Models.Enums;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class CustomerRecordRepositoryQA : ICustomerRecordRepository
    {
        private List<CustomerRecord> _customerRecords = new List<CustomerRecord>();
        private static DateTime _addedDate = new DateTime(2023, 1, 22);

        public CustomerRecordRepositoryQA()
        {
            var seedList = SeedRepo();

            foreach(var item in seedList)
            {
                _customerRecords.Add(item);
            }
        }
        public IEnumerable<CustomerRecord> SeedRepo() =>
            new List<CustomerRecord>
            {
                new CustomerRecord
                {
                    CustomerId = Guid.NewGuid() ,
                    FirstName = "Jim",
                    LastName = "Jimerson",
                    PhoneNumber = "502-555-5555",
                    AddedDate = _addedDate,
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
                    AddedDate = _addedDate,
                    AddressLineOne = "Tomson St.",
                    Email = "Tom@tom.com",
                    City = "Columbus",
                    ZipCode = "40000",
                    State = StateAbbreviation.OH
                }
            };

        public IEnumerable<CustomerRecord> GetAll()
        {
            return _customerRecords;
        }
        public void InsertCustomerRecord(CustomerRecord customerRecord)
        {
            _customerRecords.Add(customerRecord);
        }
    }
}
