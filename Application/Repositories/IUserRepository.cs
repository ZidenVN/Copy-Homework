using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Repositories
{
    public interface IUserRepository  : IGenericRepository<User>
    {
        Task<User?> GetByIdWithFullInfoAsync(Guid id);

        Task<User?> GetByEmailAsync(string email);

        Task<User?> GetByPhoneAsync(string phone);

        Task<IEnumerable<User?>> GetAllAsync(string role);
    }
}
