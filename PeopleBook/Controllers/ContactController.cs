using PeopleBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PeopleBook.Controllers
{
    public class ContactController : ApiController
    {
        List<Contact> contactList = new List<Contact>();

        public Contact GetContact(int Id)
        {
            return contactList.Where(c => c.Id == Id).Select(c => c).FirstOrDefault();
        }

        public List<Contact> GetAllContacts()
        {
            return new List<Contact>();
        }
    }
}
