
/// <summary>
/// Represents a paragraph question that inherits from BaseQuestion.
/// Sets the question type to Enums.QuestionType.Paragraph.
/// </summary>
namespace CapitalPlacement.TalentManagement.Domain
{
    public class ParagraphQuestion : BaseQuestion
    {
        public ParagraphQuestion()
        {
            Type = Enums.QuestionType.Paragraph;
        }
    }
}
