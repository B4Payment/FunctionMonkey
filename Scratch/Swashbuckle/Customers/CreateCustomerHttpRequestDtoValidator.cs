using FluentValidation;

namespace Swashbuckle.Customers
{
    public class CreateCustomerHttpRequestDtoValidator : AbstractValidator<CreateCustomerHttpRequestDto>
    {
        public CreateCustomerHttpRequestDtoValidator()
        {
            // CompanyName must be filled, or GivenName and FamilyName
            RuleFor(dto => dto).Must(c =>
                !string.IsNullOrEmpty(c.CompanyName) ||
                !string.IsNullOrEmpty(c.GivenName) && !string.IsNullOrEmpty(c.FamilyName));
        }
    }
}