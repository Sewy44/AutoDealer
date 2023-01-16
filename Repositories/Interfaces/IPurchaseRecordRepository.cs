using AutoDealer.Models.Purchase;

namespace AutoDealer.Repositories.Interfaces
{
    public interface IPurchaseRecordRepository
    {
        IEnumerable<PurchaseRecord> GetAll();
        void InsertPurchaseRecord(PurchaseRecord purchaseRecord);
    }
}
