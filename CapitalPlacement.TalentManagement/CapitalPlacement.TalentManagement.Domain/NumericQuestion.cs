namespace CapitalPlacement.TalentManagement.Domain
{
    /// <summary>
    /// Represents a numeric question derived from BaseQuestion.
    /// Sets the question type to Enums.QuestionType.Number.
    /// </summary>
    public class NumericQuestion : BaseQuestion
    {
        public NumericQuestion()
        {
            Type = Enums.QuestionType.Number;
        }
    }
}

