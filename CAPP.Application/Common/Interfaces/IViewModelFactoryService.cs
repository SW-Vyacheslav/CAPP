using CAPP.Application.Common.Enums;
using CAPP.Application.Common.Models;

namespace CAPP.Application.Common.Interfaces
{
    public interface IViewModelFactoryService
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}
