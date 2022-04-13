using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Interfaces.Models;
using Entities.Interfaces.ViewModels;

namespace ForAccountRecordsInfrastructure.Interfaces.Services
{
  public interface IContactsService
  {
    public IUserDataEntityUserContacts GetSingleSpecificContact(int id);

    public IEnumerable<IUserDataEntityUserContacts> GetAllContact();

    public IUserDataEntityUserContacts AddNewContact(IUserDataEntityUserContacts contact);


    public IUserDataEntityUserContacts EditUserContacts(IUserDataEntityUserContacts contact);

    public IUserDataEntityUserContacts DeleteUserContacts(int id);


  }

}
