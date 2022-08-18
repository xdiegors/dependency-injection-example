using DI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
           .AddTransient<IServicoEmail, EmailOutlookService>()
           .BuildServiceProvider();

            var emailService = serviceProvider.GetService<IServicoEmail>();
            emailService.EnviarEmail("Oie");
        }
    }
}
