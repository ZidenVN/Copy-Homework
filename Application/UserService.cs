using Application.Abtractions;
using Application.AppExceptions;
using Application.Constants;
using Application.Dtos.User.req;
using Application.Dtos.User.Res;
using Application.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        //public async Task<Guid> CreateAsync(CreateUserReq req)
        //{
        //    if(await _userRepository.GetByPhoneAsync(req.Phone) != null)
        //    {
        //        throw new Exception(Message.UserMessage.PhoneAlreadyExist);
        //    }
        //    if(!string.IsNullOrEmpty(req.Email))
        //    {
        //        if(await _userRepository.GetByEmailAsync(req.Email) != null)
        //        {
        //            throw new Exception(Message.UserMessage.EmailAlreadyExists);
        //        }
        //    }
        //    if(string.IsNullOrEmpty
        //        (req.RoleName)) req.RoleName = RoleName.Customer;
        //    var user = _mapper.Map<Domain.Entities.User>(req);

        //}
        public async Task<UserProfileViewRes?> GetByIdAsync(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserProfileViewRes>(user);
        }

        public async Task<UserProfileViewRes> GetByPhoneAsync(string phone)
        {
            var user = await _userRepository.GetByPhoneAsync(phone);
            if (user == null)
            {
                throw new NotFoundException(Message.UserMessage.NotFound);
            }
            var userViewRes = _mapper.Map<UserProfileViewRes>(user);
            return userViewRes;
        }
        public async Task DeleteCustomer(Guid id)
        {
            await _userRepository.DeleteAsync(id);
        }
    }
}
