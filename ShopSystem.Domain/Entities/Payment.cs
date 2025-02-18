#nullable disable

using ShopSystem.Domain.Common;
using ShopSystem.Domain.Enums;

namespace ShopSystem.Domain.Entities;

public class Payment : BaseEntity<Guid>
{
    public Guid OrderId { get; set; }
    public decimal Amount { get; set; }
    public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
    public string TransactionId { get; set; } = string.Empty;

    private Payment() { } // Required for EF Core

    public Payment(Guid orderId, decimal amount)
    {
        OrderId = orderId;
        Amount = amount;
    }

    public void Complete(string transactionId)
    {
        Status = PaymentStatus.Completed;
        TransactionId = transactionId;
    }
}
