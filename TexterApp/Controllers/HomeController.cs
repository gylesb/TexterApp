using Microsoft.AspNetCore.Mvc;
using TexterApp.Models;

namespace TexterApp.Controllers
{
    public class HomeController : Controller
    {
        //Viewing Messages
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetMessages()
        {
            var allMessages = Message.GetMessages();
            return View(allMessages);
        }

        //Sending Messages
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message newMessage)
        {
            newMessage.Send();
            return RedirectToAction("Index");
        }

        //sfsd
    }
}