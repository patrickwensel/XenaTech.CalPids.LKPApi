using AutoMapper;
using XenaTech.CalPids.LKPApi.Contracts.V1.Responses;
using XenaTech.CalPids.LKPApi.Domain;

namespace XenaTech.CalPids.LKPApi.MappingProfiles
{
    public class DomainToResponseProfile : Profile
    {
        public DomainToResponseProfile()
        {
            CreateMap<LKP, LastKnownPositionResponse>();
            CreateMap<TripLkp, TripLkpResponse>();
        }
    }
}