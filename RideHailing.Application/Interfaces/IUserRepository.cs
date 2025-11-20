using RideHailing.Domain.Entities;

namespace RideHailing.Application.Interfaces
{
    public interface IUserRepository
    {
        // Returns the created user (with generated ID)
        Task<User> AddAsync(User user, CancellationToken cancellationToken = default);

        // Returns null if not found
        Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        // Returns null if not found (needed for login)
        Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);

        // Checks existence without loading entity (more efficient)
        Task<bool> EmailExistsAsync(string email, CancellationToken cancellationToken = default);

        // Updates existing user
        Task UpdateAsync(User user, CancellationToken cancellationToken = default);

        // Persists changes to database (Unit of Work pattern)
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
