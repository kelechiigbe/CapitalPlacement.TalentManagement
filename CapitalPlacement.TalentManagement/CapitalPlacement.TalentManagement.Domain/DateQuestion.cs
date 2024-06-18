namespace CapitalPlacement.TalentManagement.Domain
{
    /// <summary>
    /// Represents a date question derived from BaseQuestion.
    /// Sets the question type to Enums.QuestionType.Date.
    /// </summary>
    public class DateQuestion : BaseQuestion
    {
        public DateQuestion()
        {
            Type = Enums.QuestionType.Date;
        }
    }
}
