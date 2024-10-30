using System;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DataAccessLayer;
using PresentationLayerWPF;
using DataAccessLayer.Repository;
using ServiceLayer.Interfaces;
using RepositoryLayer.Interfaces;
using ServiceLayer;
using BusinessObjectLayer;

namespace YourNamespace
{
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SaleManagementContext>(options =>
                options.UseSqlServer("Server=localhost;Database=SaleManagement;User Id=sa;Password=12345;TrustServerCertificate=true;"));

            // Đăng ký các Repository
            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<IPropertyRepository, PropertyRepository>();
            services.AddScoped<IPropertyCategoryRepository, PropertyCategoryRepository>();
            services.AddScoped<IRoleUserRepository, RoleUserRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<ITransactionDetailRepository, TransactionDetailRepository>();

            // Đăng ký các Service
            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<IPropertyService, PropertyService>();
            services.AddScoped<IPropertyCategoryService, PropertyCategoryService>();
            services.AddScoped<IRoleUserService, RoleUserService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<ITransactionDetailService, TransactionDetailService>();

            // Đăng ký các View
            services.AddScoped<MainWindow>();
        }
    }
}
