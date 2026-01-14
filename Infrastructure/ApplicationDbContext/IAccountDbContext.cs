using Domain.Commons;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Infrastructure.ApplicationDbContext
{
    public interface IAccountDbContext
    {
        DbSet<User> Users { get; }
        DbSet<Role> Roles { get; }
        DbSet<RefreshToken> RefreshTokens { get; }

        DbSet<T> Set<T>() where T : class;

        public EntityEntry<T> Entry<T>(T entity) where T : class;

        public int SaveChanges();

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
