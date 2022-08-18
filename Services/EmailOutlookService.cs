using System;

namespace DI.Services
{
    public class EmailOutlookService : IServicoEmail
    {
        public void EnviarEmail(string email)
        {
            Console.WriteLine($"Email enviado pelo Outlook: {email}");
        }
    }
}