using Microsoft.AspNetCore.Authorization;

namespace XenaTech.CalPids.LKPApi.Authorization
{
    public class WorksForCompanyRequirement : IAuthorizationRequirement
    {
        public string DomainName { get; }
        
        public WorksForCompanyRequirement(string domainName)
        {
            DomainName = domainName;
        }
    }
}