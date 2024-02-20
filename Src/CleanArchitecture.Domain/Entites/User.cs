using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entites;

public sealed class User : BaseEntity
{
    public string Email { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}
