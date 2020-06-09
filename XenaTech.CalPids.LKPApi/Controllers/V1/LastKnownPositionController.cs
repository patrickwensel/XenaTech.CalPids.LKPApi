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
    [ApiKeyAuth]
    [Produces("application/json")]
    public class LastKnownPositionController : ControllerBase
    {
        private readonly ILastKnownPositionService _lastKnownPositionService;
        private readonly IMapper _mapper;

        public LastKnownPositionController(ILastKnownPositionService lastKnownPositionService, IMapper mapper)
        {
            _lastKnownPositionService = lastKnownPositionService;
            _mapper = mapper;
        }

        [HttpGet(ApiRoutes.LastKnownPositions.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            var lastKnownPositions = await _lastKnownPositionService.GetAllLastKnownPositionsAsync();
            var lastKnownPositionsResponse = _mapper.Map<List<LastKnownPositionResponse>>(lastKnownPositions);
            return Ok(lastKnownPositionsResponse);
        }
    }
}
