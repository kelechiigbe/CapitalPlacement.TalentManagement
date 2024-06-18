using CapitalPlacement.TalentManagement.Domain.Enums;


namespace CapitalPlacement.TalentManagement.Domain
{
    public abstract class BaseQuestion
    {
        public QuestionType Type { get; set; }
        public string Question { get; set; }
    }
}
