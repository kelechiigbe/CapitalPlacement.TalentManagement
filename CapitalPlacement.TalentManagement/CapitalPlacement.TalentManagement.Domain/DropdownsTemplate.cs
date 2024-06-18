namespace CapitalPlacement.TalentManagement.Domain
{
    /// <summary>
    /// Represents a dropdown template question derived from BaseQuestion.
    /// Sets the question type to Enums.QuestionType.Dropdown.
    /// </summary>
    public class DropdownsTemplate: BaseQuestion
    {
        public DropdownsTemplate() {
            Type = Enums.QuestionType.DropDown;
        }

        public HashSet<string> Choice { get; set; }

        public bool EnableOtherOption { get; set; }
    }
}
