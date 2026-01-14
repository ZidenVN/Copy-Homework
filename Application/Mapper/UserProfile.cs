using Application.Dtos.User.Res;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserProfileViewRes>()
                .ForSourceMember(x => x.DeletedAt, opt => opt.DoNotValidate());

        }
    }
}
