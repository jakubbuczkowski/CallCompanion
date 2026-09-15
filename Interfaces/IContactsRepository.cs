namespace CallCompanion.Interfaces
{
    public interface IContactsRepository
    {
        IEnumerable<Contact> GetAllContacts();
        void AddContact(Contact contact);
        Contact? GetContactById(int id);
    }
}
