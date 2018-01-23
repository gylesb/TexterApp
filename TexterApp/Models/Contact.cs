using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TexterApp.Controllers.Models
{
    [Table("Contacts")]
    public class Contact
    {
        public Contact(string contactName, string contactNumber, int id)
        {
            id = ContactId;
            contactName = Name;
            contactNumber = Number;
        }

        public Contact()
        {
            
        }

        [Key]
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
    }
}