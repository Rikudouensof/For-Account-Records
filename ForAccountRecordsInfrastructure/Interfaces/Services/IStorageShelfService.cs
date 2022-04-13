using Entities.Interfaces.Models;
using Entities.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Interfaces.Services
{

  public interface IStorageShelfService
  {
    public IEntityStorageShelfViewModel GetSingleStorageShelf(int Id);

    public IEntityStorageShelfViewModel AddSingleStorageShelf(IUserDataEEntityStorageShelfs storageShelfs);
    public IEntityStorageShelfViewModel EditStorageShelf(IUserDataEEntityStorageShelfs storageShelfs);


    public IEntityStorageShelfGroupViewModel GetAllStoraheShelf();

    public IEntityStorageShelfGroupViewModel GetSpecificGroupStorageShelf(string searchTerm, int? storageSpaceId);



  }

}
