using System.Collections.Generic;

namespace XenaTech.CalPids.LKPApi.Contracts.V1.Responses
{
    public class AuthFailedResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}