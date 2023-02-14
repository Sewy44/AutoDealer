using AutoDealer.Models.Customer;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.Repositories
{
    public class CustomerRecordRepository : ICustomerRecordRepository
    {
        private readonly AutoDealerDbContext _dbContext;

        public CustomerRecordRepository(AutoDealerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<CustomerRecord> GetAll()
        {
            return _dbContext.CustomerRecords;
        }

        public void InsertCustomerRecord(CustomerRecord customerRecord)
        {
            _dbContext.CustomerRecords.Add(customerRecord);
        }
    }
}
