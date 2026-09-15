using CallCompanion.Interfaces;

namespace CallCompanion.Repositories
{
    public class ContactsRepositoryDB:IContactsRepository
    {

        public ContactsRepositoryDB()
        {

        }

        public void AddContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            throw new NotImplementedException();
        }

        public Contact? GetContactById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
