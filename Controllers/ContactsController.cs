using CallCompanion.Interfaces;
using CallCompanion.Repositories;
using CallCompanion.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CallCompanion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactsController : ControllerBase
    {
        ContactsService _contactsService;
        public ContactsController(ContactsService contactsService)
        {
            _contactsService = contactsService;
        }


        [HttpGet(Name = "GetContacts")]
        public ActionResult<IEnumerable<Contact>> Get()
        {
            var contacts = _contactsService.GetAllContacts().ToList();
            return Ok(contacts);
        }

        [HttpGet("{id}", Name = "GetContactsByID")]
        public ActionResult<Contact> Get(int id)
        {
            var foundContact = _contactsService.GetContactById(id);
            if (foundContact != null)
                return Ok(foundContact);
            else
                return NotFound();
        }

        [HttpPost(Name = "PutContacts")]
        public ActionResult<Contact> Post(Contact contact)
        {
            _contactsService.AddContact(contact);
            return Ok(contact);
        }
    }
}
