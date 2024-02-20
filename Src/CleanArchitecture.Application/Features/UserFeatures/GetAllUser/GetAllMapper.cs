using AutoMapper;
using CleanArchitecture.Domain.Entites;

namespace CleanArchitecture.Application.Features.UserFeatures.GetAllUser;

public sealed class GetAllUserMapper : Profile
{
    public GetAllUserMapper()
    {
        CreateMap<User, GetAllUserResponse>();
    }
}