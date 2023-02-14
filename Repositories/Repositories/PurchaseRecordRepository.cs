using AutoDealer.Models.Purchase;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.Repositories
{
    public class PurchaseRecordRepository : IPurchaseRecordRepository
    {
        private readonly AutoDealerDbContext _dbContext;

        public PurchaseRecordRepository(AutoDealerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<PurchaseRecord> GetAll()
        {
            return _dbContext.PurchaseRecords;
        }

        public void InsertPurchaseRecord(PurchaseRecord purchaseRecord)
        {
            _dbContext.PurchaseRecords.Add(purchaseRecord);
        }
    }
}
