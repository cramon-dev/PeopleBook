using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleBook.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; } // should I have a phone type?
    }
}