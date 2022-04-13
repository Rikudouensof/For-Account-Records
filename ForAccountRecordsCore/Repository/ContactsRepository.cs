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
    public IUserDataEntityUserContacts AddNewContact(IUserDataEntityUserContacts contact)
    {
      _db.Contacts.Add((DataContacts)contact);
      _db.SaveChanges();
      return contact;
    }

    public IUserDataEntityUserContacts DeleteUserContacts(int id)
    {
      
      var contact = _db.Contacts.Find(id);
      _db.Contacts.Remove(contact);
      _db.SaveChanges();
      return contact;
    }

    public IUserDataEntityUserContacts EditUserContacts(IUserDataEntityUserContacts contact)
    {
      _db.Contacts.Update((DataContacts)contact);
      _db.SaveChanges();
      return contact;
    }

    public IEnumerable<IUserDataEntityUserContacts> GetAllContact()
    {
      var allUserContacts = _db.Contacts.OrderBy(m => m.LastName);
      return allUserContacts;
    }

    //Find One
    public IUserDataEntityUserContacts GetSingleSpecificContact(int id)
    {
      var contact = _db.Contacts.Find(id);
      return contact;
    }
  }
}
