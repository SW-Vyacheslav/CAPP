using CAPP.UI.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace CAPP.UI.Views
{
    public partial class TechnologicalProcessView : UserControl
    {
        public TechnologicalProcessView()
        {
            InitializeComponent();
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var tp = DataContext as TechnologicalProcessViewModel;
            var tree = sender as TreeView;

            tp.OnTreeViewSelectedItemChanged(tree.SelectedItem);
        }
    }
}
