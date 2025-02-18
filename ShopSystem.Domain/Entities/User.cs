#nullable disable

using ShopSystem.Domain.Common;
using ShopSystem.Domain.Enums;

namespace ShopSystem.Domain.Entities;

public class User : BaseEntity<Guid>
{
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public UserRole Role { get; set; }

    private User() { } // Required by EF Core

    public User(string username, string passwordHash, UserRole role)
    {
        Username = username;
        PasswordHash = passwordHash;
        Role = role;
    }
}
