using Swashbuckle.AspNetCore.Filters;
using XenaTech.CalPids.LKPApi.Contracts.V1.Responses;

namespace XenaTech.CalPids.LKPApi.SwaggerExamples.Responses
{
    public class TagResponseExample : IExamplesProvider<TagResponse>
    {
        public TagResponse GetExamples()
        {
            return new TagResponse
            {
                Name = "new tag"
            };
        }
    }
}