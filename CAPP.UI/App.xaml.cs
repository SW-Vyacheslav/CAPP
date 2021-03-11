using CAPP.Application;
using CAPP.Application.Common.Interfaces;
using CAPP.Infrastructure;
using CAPP.Infrastructure.Persistence;
using CAPP.UI.Services;
using CAPP.UI.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace CAPP.UI
{
    public partial class App : System.Windows.Application
    {
        protected async override void OnStartup(StartupEventArgs e)
        {
            IServiceProvider provider = CreateServiceProvider();

            try
            {
                ApplicationDbContext context = provider.GetRequiredService<ApplicationDbContext>();

                if (context.Database.IsSqlServer())
                {
                    context.Database.Migrate();
                }

                await ApplicationDbContextSeed.SeedDefaultData(context);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred while migrating or seeding the database.\n{ex.Message}", "Error");
                throw;
            }
            
            MainWindow window = new MainWindow();
            window.DataContext = provider.GetRequiredService<MainWindowViewModel>();
            window.Show();

            base.OnStartup(e);
        }

        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddApplication();
            services.AddInfrastructure();

            services.AddTransient<MainWindowViewModel>();
            services.AddTransient<TechnologicalProcessViewModel>();
            services.AddTransient<DatabaseViewModel>();

            services.AddSingleton<CreateViewModel<TechnologicalProcessViewModel>>(services => () => services.GetRequiredService<TechnologicalProcessViewModel>());
            services.AddSingleton<CreateViewModel<DatabaseViewModel>>(services => () => services.GetRequiredService<DatabaseViewModel>());

            services.AddSingleton<IViewModelFactoryService, ViewModelFactoryService>();

            return services.BuildServiceProvider();
        }
    }
}
