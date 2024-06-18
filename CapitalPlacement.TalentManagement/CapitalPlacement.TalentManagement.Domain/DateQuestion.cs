/// <summary>
/// Represents a question related to dates.
/// </summary>
namespace CapitalPlacement.TalentManagement.Domain
{
    public class DateQuestion : BaseQuestion
    {
        public DateQuestion()
        {
            Type = Enums.QuestionType.Date;
        }
    }
}
