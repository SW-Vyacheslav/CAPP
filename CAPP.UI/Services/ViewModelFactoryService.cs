using CAPP.Application.Common.Enums;
using CAPP.Application.Common.Interfaces;
using CAPP.Application.Common.Models;
using CAPP.UI.ViewModels;
using System;

namespace CAPP.UI.Services
{
    public delegate TViewModel CreateViewModel<TViewModel>() where TViewModel : ViewModelBase;

    public class ViewModelFactoryService : IViewModelFactoryService
    {
        private readonly CreateViewModel<TechnologicalProcessViewModel> _createTechnologicalProcessViewModel;

        private readonly CreateViewModel<DatabaseViewModel> _createDatabaseViewModel;

        public ViewModelFactoryService(CreateViewModel<TechnologicalProcessViewModel> createTechnologicalProcessViewModel, 
            CreateViewModel<DatabaseViewModel> createDatabaseViewModel)
        {
            _createTechnologicalProcessViewModel = createTechnologicalProcessViewModel;
            _createDatabaseViewModel = createDatabaseViewModel;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.TechnologicalProcess:
                    return _createTechnologicalProcessViewModel();
                case ViewType.Database:
                    return _createDatabaseViewModel();
                default:
                    throw new ArgumentException("ViewType not supported.", "viewType");
            }
        }
    }
}
