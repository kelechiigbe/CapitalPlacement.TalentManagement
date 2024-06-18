using System;

namespace CapitalPlacement.TalentManagement.Domain
{
    public class ContactInfo: LabelInfo
    {
        public ContactInfo() { }
        public ContactInfo(string label)
        {
            Label = label ?? string.Empty;
        }
        public bool IsInternal { get; set; }
        public bool IsHidden { get; set; }
    }

    public class LabelInfo
    {
        public LabelInfo() { }
        public LabelInfo(string label)
        {
            Label = label ?? string.Empty;
        }
        public string Label { get; set; } = string.Empty;
    }
}
