using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using TexterApp.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace TexterApp.Controllers
{

	public class ContactController : Controller
	{
		private readonly TexterAppDbContext _db;

		public ContactController(TexterAppDbContext db)
		{
			_db = db;
		}

        //Add Contact
		public IActionResult AddContact()
		{
			return View();
		}


        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            _db.Contacts.Add(contact);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Contact Details
        public IActionResult Details(int id)
		{
			var thisContact = _db.Contacts
								  //.Include(x => x.Messages)
								  .FirstOrDefault(items => items.ContactId == id);
			return View(thisContact);
		}

        //Edit Contact
		public IActionResult Edit(int id)
		{
			var thisContact = _db.Contacts.FirstOrDefault(names => names.ContactId == id);
			return View(thisContact);
		}

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            _db.Contacts.Update(contact);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Delete Contact
        public IActionResult Delete(int id)
		{
			var thisContact = _db.Contacts.FirstOrDefault(names => names.ContactId == id);
			return View(thisContact);
		}

		[HttpPost, ActionName("Delete")]
		public IActionResult DeleteConfirmed(int id)
		{
			var thisContact = _db.Contacts.FirstOrDefault(names => names.ContactId == id);
			_db.Remove(thisContact);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}