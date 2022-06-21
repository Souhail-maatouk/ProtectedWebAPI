using AutoMapper;
using ProtectedWebAPI.Core.Models;
using ProtectedWebAPI.Models;

namespace ProtectedWebAPI.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<UserCredentialsResource, User>();
        }
    }
}