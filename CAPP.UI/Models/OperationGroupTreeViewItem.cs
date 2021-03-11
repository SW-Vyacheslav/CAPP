using System.Collections.ObjectModel;

namespace CAPP.UI.Models
{
    public class OperationGroupTreeViewItem : ITechnologicalProcessTreeViewItem
    {
        public int OperationGroupNumber { get; set; }

        public string OperationGroupName { get; set; }

        public ObservableCollection<OperationTreeViewItem> OperationTreeViewItems { get; set; }

        public string StringValue => ToString();

        public OperationGroupTreeViewItem()
        {
            OperationTreeViewItems = new ObservableCollection<OperationTreeViewItem>();
        }

        public override string ToString()
        {
            return $"Операция {OperationGroupNumber} - {OperationGroupName ?? ""}";
        }
    }
}
