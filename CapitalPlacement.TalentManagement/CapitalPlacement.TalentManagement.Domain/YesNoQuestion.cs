
namespace CapitalPlacement.TalentManagement.Domain
{
    /// <summary>
    /// Represents a Yes/No question derived from BaseQuestion.
    /// Sets the question type to Enums.QuestionType.YesNo.
    /// </summary>
    public class YesNoQuestion: BaseQuestion
    {
        public YesNoQuestion()
        {
            Type = Enums.QuestionType.YesNo;
        }
    }
}
