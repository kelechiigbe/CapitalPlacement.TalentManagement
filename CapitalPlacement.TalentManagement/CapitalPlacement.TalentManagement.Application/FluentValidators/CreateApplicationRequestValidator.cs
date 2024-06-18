using CapitalPlacement.TalentManagement.Application.ViewModel;
using FluentValidation;

namespace CapitalPlacement.TalentManagement.Application.FluentValidators
{
    public class CreateApplicationRequestValidator: AbstractValidator<CreateApplicationRequest>
    {
        /// <summary>
        /// Validates the First Name, Last Name and Email properties.
        /// </summary>
        public CreateApplicationRequestValidator()
        {
            RuleFor(application => application.FirstName).NotEmpty();
            RuleFor(application => application.LastName).NotEmpty();
            RuleFor(application => application.Email).NotEmpty();
        }
    }
}
