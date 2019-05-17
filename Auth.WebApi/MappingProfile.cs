using AutoMapper;
using Auth.WebApi.DTOs;
using static EFCore.Entities.IdnDBContext;


namespace Auth.WebApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDTO, User>(MemberList.Source);
        }
    }
}
