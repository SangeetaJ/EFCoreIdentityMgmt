using AutoMapper;
using Auth.WebApi.DTOs;
using EFCore.Entities;

namespace Auth.WebApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDTO, User>(MemberList.Source);
            CreateMap<User, UserDTO>(MemberList.Source);

            CreateMap<RoleDTO, Role>(MemberList.Source);
            CreateMap<Role, RoleDTO>(MemberList.Source);
        }
    }
}
