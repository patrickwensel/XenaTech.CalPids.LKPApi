using Microsoft.AspNetCore.Mvc;

namespace XenaTech.CalPids.LKPApi.Contracts.V1.Requests.Queries
{
    public class GetAllPostsQuery
    {
        [FromQuery(Name = "userId")]
        public string UserId { get; set; }
    }
}