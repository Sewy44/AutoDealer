using AutoDealer.Models.Customer;

namespace AutoDealer.Repositories.Interfaces
{
    public interface ICustomerRecordRepository
    {
        void InsertCustomerRecord(CustomerRecord customerRecord);
        IEnumerable<CustomerRecord> GetAll();
    }
}
