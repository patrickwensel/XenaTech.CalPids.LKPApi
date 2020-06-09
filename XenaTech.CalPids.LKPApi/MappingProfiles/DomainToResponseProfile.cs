using System.Linq;
using AutoMapper;
using XenaTech.CalPids.LKPApi.Contracts.V1.Responses;
using XenaTech.CalPids.LKPApi.Domain;

namespace XenaTech.CalPids.LKPApi.MappingProfiles
{
    public class DomainToResponseProfile : Profile
    {
        public DomainToResponseProfile()
        {
            CreateMap<Post, PostResponse>()
                .ForMember(dest => dest.Tags, opt => 
                    opt.MapFrom(src => src.Tags.Select(x => new TagResponse{Name = x.TagName})));
            
            CreateMap<Tag, TagResponse>();
        }
    }
}