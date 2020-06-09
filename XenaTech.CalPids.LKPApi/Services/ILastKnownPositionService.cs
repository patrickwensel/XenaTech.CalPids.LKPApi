using System.Collections.Generic;
using System.Threading.Tasks;
using XenaTech.CalPids.LKPApi.Domain;

namespace XenaTech.CalPids.LKPApi.Services
{
    public interface ILastKnownPositionService
    {
        Task<List<LKP>> GetAllLastKnownPositionsAsync();
    }
}