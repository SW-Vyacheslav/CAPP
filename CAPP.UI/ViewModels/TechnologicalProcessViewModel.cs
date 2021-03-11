using CAPP.Application.Common.Interfaces;
using CAPP.Application.Common.Models;
using CAPP.Domain.Entities;
using CAPP.UI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;

namespace CAPP.UI.ViewModels
{
    public class TechnologicalProcessViewModel : ViewModelBase
    {
        private readonly IApplicationDbContext _context;
        private OperationGroup _selectedOperationGroup;
        private Operation _selectedOperation;

        public ObservableCollection<ITechnologicalProcessTreeViewItem> TreeItems { get; set; }

        public ITechnologicalProcessTreeViewItem SelectedTreeViewItem { get; set; }

        public List<OperationGroup> OperationGroups => _context.OperationGroups.ToList();

        public OperationGroup SelectedOperationGroup 
        { 
            get => _selectedOperationGroup; 
            set 
            { 
                _selectedOperationGroup = value;
                SelectFirstOperation();
                NotifyPropertyChanged("Operations");                
            }
        }

        public Operation SelectedOperation
        {
            get => _selectedOperation;
            set
            {
                _selectedOperation = value;
                SelectFirstOperationObject();
                NotifyPropertyChanged("OperationObjects");
            }
        }

        public OperationObject SelectedOperationObject { get; set; }

        public List<Operation> Operations
        {
            get
            {
                if (SelectedOperationGroup == null)
                    return new List<Operation>();

                return _context.OperationGroupOperations
                     .Where(ogo => ogo.OperationGroupId == SelectedOperationGroup.Id)
                     .Include(ogo => ogo.Operation)
                     .Select(ogo => ogo.Operation)
                     .ToList();
            }
        }

        public List<OperationObject> OperationObjects
        {
            get
            {
                if (SelectedOperation == null)
                    return new List<OperationObject>();

                return _context.OperationOperationObjects
                     .Where(ooo => ooo.OperationId == SelectedOperation.Id)
                     .Include(ooo => ooo.OperationObject)
                     .Select(ooo => ooo.OperationObject)
                     .ToList();
            }
        }

        public DelegateCommand AddOperationGroupCommand { get; set; }

        public DelegateCommand AddOperationCommand { get; set; }

        public int Number { get; set; }

        public int Id { get; set; }

        public Size Size1 { get; set; }

        public Size Size2 { get; set; }

        public Size Size3 { get; set; }

        public TechnologicalProcessViewModel(IApplicationDbContext context)
        {
            _context = context;

            Id = 1;
            Number = 1;
            SelectedOperationGroup = OperationGroups.First();
            TreeItems = new ObservableCollection<ITechnologicalProcessTreeViewItem>();
            Size1 = new Size();
            Size2 = new Size();
            Size3 = new Size();

            AddOperationGroupCommand = new DelegateCommand((o) => AddOperationGroup());
            AddOperationCommand = new DelegateCommand((o) => AddOperation());
        }

        public void SelectFirstOperation()
        {
            SelectedOperation = Operations.First();
        }

        public void SelectFirstOperationObject()
        {
            SelectedOperationObject = OperationObjects.First();
        }

        public void OnTreeViewSelectedItemChanged(object selectedItem)
        {
            SelectedTreeViewItem = (ITechnologicalProcessTreeViewItem)selectedItem;
            NotifyPropertyChanged("SelectedTreeViewItem");
        }

        private void AddOperationGroup()
        {
            OperationGroupTreeViewItem og = new OperationGroupTreeViewItem();
            og.OperationGroupNumber = Number;
            og.OperationGroupName = (string)SelectedOperationGroup.Name.Clone();

            TreeItems.Add(og);
        }

        private void AddOperation()
        {
            if (SelectedTreeViewItem == null)
                return;

            Type selectedTreeViewItemType = SelectedTreeViewItem.GetType();

            if (selectedTreeViewItemType.IsAssignableFrom(typeof(OperationGroupTreeViewItem)))
            {
                OperationTreeViewItem o = new OperationTreeViewItem();
                o.OperationId = Id;
                o.OperationName = SelectedOperation.KeyWord;
                o.OperationObjectName = SelectedOperationObject.Name;
                o.Size1 = Size1;
                o.Size2 = Size2;
                o.Size3 = Size3;

                var selectedTreeViewItem = SelectedTreeViewItem as OperationGroupTreeViewItem;
                selectedTreeViewItem.OperationTreeViewItems.Add(o);
            }
        }
    }
}
