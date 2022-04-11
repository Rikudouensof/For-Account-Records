using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Interfaces.Repository
{
  public interface IStorageSpaceRepository
  {
    public IEntityStorageSpace GetSingleSpecificStorageSpace(int id);


    public IEnumerable<IEntityStorageSpace> GetAllStorageSpace();


    public IEnumerable<IEntityStorageSpace> GetSearchedStorageSpace(string searchTerm);


    public IEntityStorageSpace AddSingleStorageSpace(IEntityStorageSpace storageSpace);


    public IEntityStorageSpace EditStorageSpace(IEntityStorageSpace storageSpace);
  }
}
