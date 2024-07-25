using ECommerceProject.Models.ViewModels;

namespace ECommerceProject.MessagingSystem
{
    public interface IMessenger
    {
        Task SendMessageAsync(ContactFormViewModel form);
    }
}
