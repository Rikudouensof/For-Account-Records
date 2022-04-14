using Entities.Interfaces.Models;
using ForAccountRecordsCore.Data;
using ForAccountRecordsCore.Models;
using ForAccountRecordsInfrastructure.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsCore.Repository
{
  internal class ContactsRepository : IContactsRepository
  {
    private ForAccountRecordsDbContext _db;
    public ContactsRepository(ForAccountRecordsDbContext db)
    {
      _db = db;
    }
    public IEntityUserContacts AddNewContact(IEntityUserContacts contact)
    {
      _db.Contacts.Add((DataContacts)contact);
      _db.SaveChanges();
      return contact;
    }

    public IEntityUserContacts DeleteUserContacts(int id)
    {
      
      var contact = _db.Contacts.Find(id);
      _db.Contacts.Remove(contact);
      _db.SaveChanges();
      return contact;
    }

    public IEntityUserContacts EditUserContacts(IEntityUserContacts contact)
    {
      _db.Contacts.Update((DataContacts)contact);
      _db.SaveChanges();
      return contact;
    }

    public IEnumerable<IEntityUserContacts> GetAllContact()
    {
      var allUserContacts = _db.Contacts.OrderBy(m => m.LastName);
      return allUserContacts;
    }

    //Find One
    public IEntityUserContacts GetSingleSpecificContact(int id)
    {
      var contact = _db.Contacts.Find(id);
      return contact;
    }
  }
}
