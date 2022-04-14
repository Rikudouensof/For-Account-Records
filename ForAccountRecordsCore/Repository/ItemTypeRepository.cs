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
  internal class ItemTypeRepository : IItemTypeRepository
  {

    private ForAccountRecordsDbContext _db;
    public ItemTypeRepository(ForAccountRecordsDbContext db)
    {
      _db = db;
    }



    public IEntityItemType AddSingleItemType(IEntityItemType itemType)
    {
      _db.ItemTypes.Add((DataItemType)itemType);
      _db.SaveChanges();
      return itemType;
    }

    public IEntityItemType EditItemType(IEntityItemType itemType)
    {
      _db.ItemTypes.Update((DataItemType)itemType);
      _db.SaveChanges();
      return itemType;
    }

    public IEnumerable<IEntityItemType> GetAllItemType()
    {
      var itemTypes = _db.ItemTypes.OrderBy(m => m.DateUploaded);
      return itemTypes;
    }

    public IEntityItemType GetSingleSpecificItemType(int id)
    {
      var itemType = _db.ItemTypes.Find(id);
      return itemType;
    }
  }
}
