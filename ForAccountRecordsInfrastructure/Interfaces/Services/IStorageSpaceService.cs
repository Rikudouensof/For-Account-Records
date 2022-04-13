using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Interfaces.Services
{
  public interface IStorageSpaceService
  {
    public IUserDataEEntityStorageSpace GetSingleSpecificStorageSpace(int id);


    public IEnumerable<IUserDataEEntityStorageSpace> GetAllStorageSpace();


    public IEnumerable<IUserDataEEntityStorageSpace> GetSearchedStorageSpace(string searchTerm);


    public IUserDataEEntityStorageSpace AddSingleStorageSpace(IUserDataEEntityStorageSpace storageSpace);


    public IUserDataEEntityStorageSpace EditStorageSpace(IUserDataEEntityStorageSpace storageSpace);
  }
}
