using CallCompanion.Interfaces;

namespace CallCompanion.Repositories
{
    public class ContactsRepository:IContactsRepository
    {
        string[] _contactSampleNames = { "Adam Nowak", "Jan Nowak" };
        public List<Contact> Contacts = null;
        public ContactsRepository()
        {
            Contacts = Enumerable.Range(0, _contactSampleNames.Count()).Select(x =>
                                             new Contact { Id = x + 1, Name = _contactSampleNames[x] }).ToList();
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return Contacts;
        }

        public void AddContact(Contact contact)
        {
            //Get id tylko w RAM, przy bazie i wielu requestach mogą dostać takie samo id.
            int contactId = Contacts.Max(x => x.Id) + 1;
            contact.Id = contactId;
            Contacts.Add(contact);
        }

        public Contact? GetContactById(int id)
        {
            return Contacts.FirstOrDefault(x => x.Id == id);
        }
    }
}
