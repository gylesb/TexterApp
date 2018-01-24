using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TexterApp.Models
{
    [Table("Contact")]
    public class Contact
    {
        public Contact(string contactFirstName, string contactLastName, string contactNumber, int id)
        {
            id = ContactId;
            contactFirstName = FirstName;
            contactLastName = LastName;
            contactNumber = Number;
        }

        public Contact()
        {

        }

        [Key]
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
    }
}