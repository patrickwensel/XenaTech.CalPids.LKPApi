using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XenaTech.CalPids.LKPApi.Data;
using XenaTech.CalPids.LKPApi.Domain;

namespace XenaTech.CalPids.LKPApi.Services
{
    public class LastKnownPositionService : ILastKnownPositionService
    {
        private readonly DataContext _dataContext;

        public LastKnownPositionService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<LKP>> GetAllLastKnownPositionsAsync()
        {
            return await _dataContext.LKPs.ToListAsync();
        }
    }
}