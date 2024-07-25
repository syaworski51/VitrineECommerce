using ECommerceProject.MessagingSystem;
using ECommerceProject.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMessenger _messenger;
        
        public ContactController(IMessenger messenger)
        {
            _messenger = messenger;
        }

        // GET: ContactController
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index([Bind("FirstName,LastName,ContactPreference,EmailAddress,PhoneNumber,Subject,Message")] ContactFormViewModel form)
        {
            form.TimeSent = DateTime.Now;

            if (ModelState.IsValid)
            {
                await _messenger.SendMessageAsync(form);
                return RedirectToAction(nameof(Success));
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
