using FluentValidation;
using XenaTech.CalPids.LKPApi.Contracts.V1.Requests;

namespace XenaTech.CalPids.LKPApi.Validators
{
    public class CreateTagRequestValidator : AbstractValidator<CreateTagRequest>
    {
        public CreateTagRequestValidator()
        {
            RuleFor(x => x.TagName)
                .NotEmpty()
                .Matches("^[a-zA-Z0-9 ]*$");
        }
    }
}