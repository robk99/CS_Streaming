using AutoMapper;
using CS.Session.Infrastructure.Dtos;

namespace CS.Session.Infrastructure.Services.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Domain.Sessions.Session, SessionDto>();
        }
    }
}
