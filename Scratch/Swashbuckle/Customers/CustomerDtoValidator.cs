using FluentValidation;

namespace Swashbuckle.Customers
{
    public class CustomerDtoValidator : AbstractValidator<CustomerDto>
    {
        public CustomerDtoValidator()
        {
            // CompanyName must be filled, or GivenName and FamilyName
            RuleFor(dto => dto).Must(c =>
                !string.IsNullOrEmpty(c.CompanyName) ||
                !string.IsNullOrEmpty(c.GivenName) && !string.IsNullOrEmpty(c.FamilyName));

            RuleFor(dto => dto.CreatedAt)
                .NotEmpty();
        }
    }
}