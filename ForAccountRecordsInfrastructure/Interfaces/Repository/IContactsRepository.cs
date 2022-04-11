using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Interfaces.Models;
using Entities.Interfaces.ViewModels;

namespace ForAccountRecordsInfrastructure.Interfaces.Repository
{
  public interface IContactsRepository
  {
    public IEntityUserContacts GetSingleSpecificContact(int id);

    public IEnumerable<IEntityUserContacts> GetAllContact();

    public IEntityUserContacts AddNewContact(IEntityUserContacts contact);


    public IEntityUserContacts EditUserContacts(IEntityUserContacts contact);

    public IEntityUserContacts DeleteUserContacts(int id);


  }

}
