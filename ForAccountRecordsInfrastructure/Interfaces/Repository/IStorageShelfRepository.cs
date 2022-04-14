using Entities.Interfaces.Models;
using Entities.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Interfaces.Repository
{

  public interface IStorageShelfRepository
  {
    public IEntityStorageShelfs GetSingleStorageShelf(int Id);

    public IEntityStorageShelfs AddSingleStorageShelf(IEntityStorageShelfs storageShelfs);
    public IEntityStorageShelfs EditStorageShelf(IEntityStorageShelfs storageShelfs);


    public IEnumerable<IEntityStorageShelfs> GetAllStoraheShelf();




  }

}
