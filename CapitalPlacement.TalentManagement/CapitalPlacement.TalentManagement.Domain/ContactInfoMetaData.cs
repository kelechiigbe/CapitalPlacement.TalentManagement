using System;

namespace CapitalPlacement.TalentManagement.Domain
{
    public class ContactInfoMetaData: LabelInfoMetaData
    {
        public ContactInfoMetaData() { }
        public ContactInfoMetaData(string label)
        {
            Label = label ?? string.Empty;
        }
        public bool IsInternal { get; set; }
        public bool IsHidden { get; set; }
    }

    public class LabelInfoMetaData
    {
        public LabelInfoMetaData() { }
        public LabelInfoMetaData(string label)
        {
            Label = label ?? string.Empty;
        }
        public string Label { get; set; } = string.Empty;
    }
}
