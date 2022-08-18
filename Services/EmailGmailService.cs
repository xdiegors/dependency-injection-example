using System;

namespace DI.Services
{
    public class EmailGmailService : IServicoEmail
    {
        public void EnviarEmail(string email)
        {
            Console.WriteLine($"Email enviado pelo GMail: {email}");
        }
    }
}