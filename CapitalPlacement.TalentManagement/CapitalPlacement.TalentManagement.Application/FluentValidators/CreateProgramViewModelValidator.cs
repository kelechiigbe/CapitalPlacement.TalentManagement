using CapitalPlacement.TalentManagement.Application.ViewModel;
using FluentValidation;
namespace CapitalPlacement.TalentManagement.Application.FluentValidators
{
    /// <summary>
    /// Validator for the CreateProgramViewModel class.
    /// </summary>
    public class CreateProgramViewModelValidator : AbstractValidator<CreateProgramRequest>
    {
        /// <summary>
        /// Validates the Title and Description properties.
        /// </summary>
        public CreateProgramViewModelValidator()
        {
            RuleFor(program => program.Title).NotEmpty();
            RuleFor(program => program.Description).NotEmpty();
        }
    }
}
