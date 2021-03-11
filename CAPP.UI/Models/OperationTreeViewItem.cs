using System.Text;

namespace CAPP.UI.Models
{
    public class OperationTreeViewItem : ITechnologicalProcessTreeViewItem
    {
        public string OperationName { get; set; }

        public int OperationId { get; set; }

        public string OperationObjectName { get; set; }

        public Size Size1 { get; set; }

        public Size Size2 { get; set; }

        public Size Size3 { get; set; }

        public string StringValue => ToString();

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{OperationName} {OperationObjectName} {OperationId}:");

            if (Size1 != null)
                result.Append($" {Size1.Name}={Size1.Value}");

            if (Size2 != null)
                result.Append($" ,{Size2.Name}={Size2.Value}");

            if (Size3 != null)
                result.Append($" ,{Size3.Name}={Size3.Value}");

            return result.ToString();
        }
    }
}
