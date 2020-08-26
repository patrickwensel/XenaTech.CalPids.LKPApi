using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XenaTech.CalPids.LKPApi.Data;
using XenaTech.CalPids.LKPApi.Domain;

namespace XenaTech.CalPids.LKPApi.Services
{
    public class TripLkpService : ITripLkpService
    {
        private readonly XtCalPidsDbContext _dataContext;

        public TripLkpService(XtCalPidsDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<TripLkp>> GetAllAsync()
        {
            return await _dataContext.TripLkps.ToListAsync();
        }
    }
}
