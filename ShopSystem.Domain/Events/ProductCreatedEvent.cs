#nullable disable

using ShopSystem.Domain.Common;

namespace ShopSystem.Domain.Events;

public record ProductCreatedEvent(Guid ProductId) : IDomainEvent;
