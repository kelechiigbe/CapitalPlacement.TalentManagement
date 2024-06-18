using CapitalPlacement.TalentManagement.Application.ViewModel;
using FluentValidation;
namespace CapitalPlacement.TalentManagement.Application.FluentValidators
{
    /// <summary>
    /// Validator for the CreateProgramViewModel class.
    /// </summary>
    public class CreateProgramRequestValidator : AbstractValidator<CreateProgramRequest>
    {
        /// <summary>
        /// Validates the Title, Description , First Name, Last Name and Email properties.
        /// </summary>
        public CreateProgramRequestValidator()
        {
            RuleFor(program => program.Title).NotEmpty();
            RuleFor(program => program.Description).NotEmpty();
            RuleFor(program => program.FirstName.Label).NotEmpty();
            RuleFor(program => program.LastName.Label).NotEmpty();
            RuleFor(program => program.Email.Label).NotEmpty();
        }
    }
}
