﻿#nullable disable

using ShopSystem.Domain.Common;

namespace ShopSystem.Domain.ValueObjects;

public class Money : ValueObject
{
    public decimal Amount { get; }
    public string Currency { get; }

    private Money() { }

    public Money(decimal amount, string currency)
    {
        if (amount < 0) throw new ArgumentException("Amount cannot be negative.");
        Amount = amount;
        Currency = currency ?? throw new ArgumentNullException(nameof(currency));
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Amount;
        yield return Currency;
    }
}
