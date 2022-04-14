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
  internal class StorageSpaceRepository : IStorageSpaceRepository
  {

    private ForAccountRecordsDbContext _db;
    public StorageSpaceRepository(ForAccountRecordsDbContext db)
    {
      _db = db;
    }
    public IEntityStorageSpace AddSingleStorageSpace(IEntityStorageSpace storageSpace)
    {
      _db.StorageSpaces.Add((DataStorageSpace)storageSpace);
      _db.SaveChanges();
      return storageSpace;
    }

    public IEntityStorageSpace EditStorageSpace(IEntityStorageSpace storageSpace)
    {
      _db.StorageSpaces.Update((DataStorageSpace)storageSpace);
      _db.SaveChanges();
      return storageSpace;
    }

    public IEnumerable<IEntityStorageSpace> GetAllStorageSpace()
    {
      var storageSpaces = _db.StorageSpaces.OrderByDescending(m => m.DateUploaded);
      return storageSpaces;
    }

    public IEntityStorageSpace GetSingleSpecificStorageSpace(int id)
    {
      var storageSpace = _db.StorageSpaces.Find(id);
      return storageSpace;
    }
  }
}
