using AutoDealer.Models;
using AutoDealer.Models.Customer;
using AutoDealer.Models.Enums;
using AutoDealer.Models.Purchase;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class MockPurchaseRecordRepository : IPurchaseRecordRepository
    {
        private readonly List<PurchaseRecord>? _purchaseRecords;
        public IEnumerable<PurchaseRecord> GetAll() =>
           new List<PurchaseRecord>
            {
                new PurchaseRecord()
                {
                    PurchaseId = Guid.NewGuid(),
                    TypeOfPurchase = PurchaseType.DealerFinance,
                    PurchasedVehicleRecord = new VehicleRecord(),
                    PurchasingCustomer = new CustomerRecord(),
                    PurchaseDate = DateTime.Now,
                    PurchasePrice = 50000,
                    SalesRepresentative = "Jamie Seward"
                },
                new PurchaseRecord()
                {
                    PurchaseId = Guid.NewGuid(),
                    TypeOfPurchase = PurchaseType.BankFinance,
                    PurchasedVehicleRecord = new VehicleRecord(),
                    PurchasingCustomer = new CustomerRecord(),
                    PurchaseDate = DateTime.Now,
                    PurchasePrice = 30000,
                    SalesRepresentative = "Jamie Seward"
                }
            };

        public void InsertPurchaseRecord(PurchaseRecord purchaseRecord)
        {
            _purchaseRecords?.Add(purchaseRecord);
        }
    }
}
