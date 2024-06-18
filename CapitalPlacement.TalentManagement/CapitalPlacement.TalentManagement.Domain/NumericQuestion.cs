
/// <summary>
/// Represents a numeric question that is of type Number.
/// </summary>
namespace CapitalPlacement.TalentManagement.Domain
{
    public class NumericQuestion : BaseQuestion
    {
        public NumericQuestion()
        {
            Type = Enums.QuestionType.Number;
        }
    }
}

