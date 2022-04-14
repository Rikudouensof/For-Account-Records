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
  internal class StorageShelfRepository : IStorageShelfRepository
  {

    private ForAccountRecordsDbContext _db;
    public StorageShelfRepository(ForAccountRecordsDbContext db)
    {
      _db = db;
    }


    public IEntityStorageShelfs AddSingleStorageShelf(IEntityStorageShelfs storageShelfs)
    {
      _db.StorageShelf.Add((DataStorageShelf)storageShelfs);
      _db.SaveChanges();
      return storageShelfs;
    }

    public IEntityStorageShelfs EditStorageShelf(IEntityStorageShelfs storageShelfs)
    {
      _db.StorageShelf.Update((DataStorageShelf)storageShelfs);
      _db.SaveChanges();
      return storageShelfs;
    }

    public IEnumerable<IEntityStorageShelfs> GetAllStoraheShelf()
    {
      var storageShelfs = _db.StorageShelf.OrderByDescending(m => m.DateUploaded);
      return storageShelfs;
    }

    public IEntityStorageShelfs GetSingleStorageShelf(int id)
    {
      var storageShelf = _db.StorageShelf.Find(id);
      return storageShelf;
    }
  }
}
