using CallCompanion.Data;
using CallCompanion.Interfaces;

namespace CallCompanion.Repositories
{
    public class ContactsRepositoryDB:IContactsRepository
    {
        private readonly CallCompanionDbContext _context;
        public ContactsRepositoryDB(CallCompanionDbContext context)
        {
            _context = context;
        }

        public void AddContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return _context.Contacts.ToList();
        }

        public Contact? GetContactById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
