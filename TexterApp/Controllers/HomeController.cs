using Microsoft.AspNetCore.Mvc;
using TexterApp.Controllers.Models;
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

        //Contacts
        public IActionResult NewContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewContact(Contact item)
        {
            //db.Contacts.Add(item);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}