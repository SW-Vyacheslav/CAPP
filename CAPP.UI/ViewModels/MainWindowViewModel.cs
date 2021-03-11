using System;
using System.Collections.Generic;
using System.Windows.Controls;
using CAPP.Application.Common.Enums;
using CAPP.Application.Common.Interfaces;
using CAPP.Application.Common.Models;
using CAPP.UI.Views;

namespace CAPP.UI.ViewModels
{
    public class MainWindowViewModel
    {
        private readonly IViewModelFactoryService _viewModelFactoryService;

        public List<UserControl> CurrentControls { get; set; }

        public DelegateCommand ShowTreeViewCommand { get; set; }

        public DelegateCommand ShowDatabaseViewCommand { get; set; }

        public DelegateCommand CloseApplicationCommand { get; set; }

        public MainWindowViewModel(IViewModelFactoryService viewModelFactoryService)
        {
            _viewModelFactoryService = viewModelFactoryService;

            CurrentControls = new List<UserControl>();
            CurrentControls.Add(new TechnologicalProcessView() 
            { 
                DataContext = (TechnologicalProcessViewModel)_viewModelFactoryService.CreateViewModel(ViewType.TechnologicalProcess) 
            });
            CurrentControls.Add(new DatabaseView()
            {
                DataContext = (DatabaseViewModel)_viewModelFactoryService.CreateViewModel(ViewType.Database)
            });

            ShowTreeViewCommand = new DelegateCommand((o) => ShowTreeView());
            ShowDatabaseViewCommand = new DelegateCommand((o) => ShowDatabaseView());
            CloseApplicationCommand = new DelegateCommand((o) => Environment.Exit(0));
        }

        private void ShowDatabaseView()
        {
            CurrentControls[0].Visibility = System.Windows.Visibility.Collapsed;
            CurrentControls[1].Visibility = System.Windows.Visibility.Visible;
        }

        private void ShowTreeView()
        {
            CurrentControls[1].Visibility = System.Windows.Visibility.Collapsed;
            CurrentControls[0].Visibility = System.Windows.Visibility.Visible;
        }
    }
}
