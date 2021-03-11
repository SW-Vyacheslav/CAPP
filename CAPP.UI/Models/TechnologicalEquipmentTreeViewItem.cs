namespace CAPP.UI.Models
{
    public class TechnologicalEquipmentTreeViewItem : ITechnologicalProcessTreeViewItem
    {
        public string InstrumentName { get; set; }

        public string RiggingName { get; set; }

        public string ControlsName { get; set; }

        public string StringValue => ToString();

        public override string ToString()
        {
            return $"{InstrumentName}, {RiggingName}, {ControlsName}";
        }
    }
}
