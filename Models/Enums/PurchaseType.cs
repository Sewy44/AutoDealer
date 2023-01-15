using System.ComponentModel;

namespace AutoDealer.Models.Enums
{
    public enum PurchaseType
    {
        [Description("Bank Finance")]
        BankFinance,
        Cash,
        [Description("Dealer Finance")]
        DealerFinance
    }
}
