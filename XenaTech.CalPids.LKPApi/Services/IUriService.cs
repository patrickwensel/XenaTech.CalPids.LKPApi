using System;
using XenaTech.CalPids.LKPApi.Contracts.V1.Requests.Queries;

namespace XenaTech.CalPids.LKPApi.Services
{
    public interface IUriService
    {
        Uri GetPostUri(string postId);

        Uri GetAllPostsUri(PaginationQuery pagination = null);
    }
}