using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TradeNowLibrary;

namespace TradeNow
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IServiceCollection services = new ServiceCollection();

            Startup startup = new Startup();
            startup.ConfigureServices(services);

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            // entry to run app
            serviceProvider.GetService<Runner>().Run();

        }
    }

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IOrderWriterService, OrderWriterService>();
            services.AddTransient<Runner>();
        }
    }
    public class Runner
    {
        private readonly IOrderWriterService _orderWriterService;

        public Runner(IOrderWriterService orderWriterService)
        {
            _orderWriterService = orderWriterService;
        }
        public void Run()
        {
            Application.Run(new LoginForm(_orderWriterService));
        }
    }
}
