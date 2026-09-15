using CallCompanion.Interfaces;

namespace CallCompanion.Services
{
    public class ContactsService
    {
        private readonly IContactsRepository _contactsRepository;
        public ContactsService(IContactsRepository contactsRepository)
        {
            _contactsRepository = contactsRepository;
        }

        public IEnumerable<Contact> GetAllContacts() => _contactsRepository.GetAllContacts();
        public Contact? GetContactById(int id) => _contactsRepository.GetContactById(id);
        public void AddContact(Contact contact) => _contactsRepository.AddContact(contact);

    }
}
