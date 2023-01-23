using AutoDealer.Models;
using AutoDealer.Models.Customer;
using AutoDealer.Models.Enums;
using AutoDealer.Models.Purchase;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class PurchaseRecordRepositoryQA : IPurchaseRecordRepository
    {
        private readonly List<PurchaseRecord>? _purchaseRecords = new List<PurchaseRecord>();

        private static DateTime _purchaseDate = new DateTime(2023,1,22);

        public PurchaseRecordRepositoryQA()
        {
            var seedList = SeedRepo();

            foreach(var record in seedList)
            {
                _purchaseRecords.Add(record);
            }
        }
        public IEnumerable<PurchaseRecord> SeedRepo() =>
           new List<PurchaseRecord>
            {
                new PurchaseRecord()
                {
                    PurchaseId = Guid.NewGuid(),
                    TypeOfPurchase = PurchaseType.DealerFinance,
                    PurchasedVehicleRecord = new VehicleRecord(),
                    PurchasingCustomer = new CustomerRecord(),
                    PurchaseDate = _purchaseDate,
                    PurchasePrice = 50000,
                    SalesRepresentative = "Jamie Seward"
                },
                new PurchaseRecord()
                {
                    PurchaseId = Guid.NewGuid(),
                    TypeOfPurchase = PurchaseType.BankFinance,
                    PurchasedVehicleRecord = new VehicleRecord(),
                    PurchasingCustomer = new CustomerRecord(),
                    PurchaseDate = _purchaseDate,
                    PurchasePrice = 30000,
                    SalesRepresentative = "Jamie Seward"
                }
            };

        public void InsertPurchaseRecord(PurchaseRecord purchaseRecord)
        {
            _purchaseRecords?.Add(purchaseRecord);
        }

        public IEnumerable<PurchaseRecord> GetAll()
        {
            return _purchaseRecords;
        }
    }
}
