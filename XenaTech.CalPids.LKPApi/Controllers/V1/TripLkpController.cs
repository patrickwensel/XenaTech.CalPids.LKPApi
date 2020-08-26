using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using XenaTech.CalPids.LKPApi.Contracts.V1;
using XenaTech.CalPids.LKPApi.Contracts.V1.Responses;
using XenaTech.CalPids.LKPApi.Filters;
using XenaTech.CalPids.LKPApi.Services;

namespace XenaTech.CalPids.LKPApi.Controllers.V1
{
    [XtCalPidsApiKeyAuth]
    [Produces("application/json")]
    public class TripLkpController : ControllerBase
    {
        private readonly ITripLkpService _tripLkpService;
        private readonly IMapper _mapper;

        public TripLkpController(ITripLkpService tripLkpService, IMapper mapper)
        {
            _tripLkpService = tripLkpService;
            _mapper = mapper;
        }

        [HttpGet(ApiRoutes.TripLkps.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            var tripLkps = await _tripLkpService.GetAllAsync();
            var tripLkpResponse = _mapper.Map<List<TripLkpResponse>>(tripLkps);
            return Ok(tripLkpResponse);
        }
    }
}
