
using ECommerceProject.Models.ViewModels;
using System.Net;
using System.Net.Mail;

namespace ECommerceProject.MessagingSystem
{
    public class Messenger : IMessenger
    {
        IConfiguration _configuration;

        public Messenger(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task SendMessageAsync(ContactFormViewModel form)
        {
            var credentials = _configuration.GetSection("Secrets:SMTP");
            var host = credentials.GetValue<string>("Host");
            var port = credentials.GetValue<int>("Port");
            var email = credentials.GetValue<string>("Address");
            var password = credentials.GetValue<string>("Password");

            var client = new SmtpClient(host, port)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(email, password)
            };
            var _message = new MailMessage(from: email, to: email, form.Subject, form.Message);

            return client.SendMailAsync(_message);
        }
    }
}
