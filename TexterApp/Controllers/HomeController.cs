using Microsoft.AspNetCore.Mvc;
using TexterApp.Models;
using TexterApp.Controllers;

namespace TexterApp.Controllers
{
    public class HomeController : Controller
    {

		//private readonly TexterAppDbContext _db;

		//public HomeController(TexterAppDbContext db)
		//{
		//	_db = db;
		//}

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

        //Add Contact
        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContact(Contact item)
        {
            //db.Contacts.Add(item);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Address Book
        //public IActionResult AddressBook()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult ViewContacts()
        //{
        //    var ViewContacts = Contact.Contact();
        //    return View(ViewContacts);
        //}
    }
}