
namespace CapitalPlacement.TalentManagement.Domain
{
    /// <summary>
    /// Represents a template for a multiple-choice question derived from DropdownsTemplate.
    /// Sets the question type to Enums.QuestionType.DropdownsTemplate.
    /// </summary>
    public class MultiChoiceQuestionTemplate : DropdownsTemplate
    {
        public MultiChoiceQuestionTemplate()
        {

            Type = Enums.QuestionType.MultipleChoice;
        }

        public int MaxChoiceAllowed { get; set; }
    }
}

