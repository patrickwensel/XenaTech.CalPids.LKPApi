using Swashbuckle.AspNetCore.Filters;
using XenaTech.CalPids.LKPApi.Contracts.V1.Requests;

namespace XenaTech.CalPids.LKPApi.SwaggerExamples.Requests
{
    public class CreateTagRequestExample : IExamplesProvider<CreateTagRequest>
    {
        public CreateTagRequest GetExamples()
        {
            return new CreateTagRequest
            {
                TagName = "new tag"
            };
        }
    }
}