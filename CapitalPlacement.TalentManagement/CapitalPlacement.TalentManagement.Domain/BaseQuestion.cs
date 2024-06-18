using CapitalPlacement.TalentManagement.Domain.Enums;

namespace CapitalPlacement.TalentManagement.Domain
{
    /// <summary>
    /// Represents a base question with properties for type and question text.
    /// </summary>
    public abstract class BaseQuestion
    {
        public QuestionType Type { get; set; }
        public string? Question { get; set; }
    }
}
