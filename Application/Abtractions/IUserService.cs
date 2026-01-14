using Application.Dtos.User.req;
using Application.Dtos.User.Res;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Abtractions
{
    public interface IUserService
    {
        //Task<Guid> CreateAsync(CreateUserReq req);
        Task<UserProfileViewRes> GetByPhoneAsync(string phone);
        Task<UserProfileViewRes?> GetByIdAsync(Guid id);
        Task DeleteCustomer(Guid id);
    }
}
