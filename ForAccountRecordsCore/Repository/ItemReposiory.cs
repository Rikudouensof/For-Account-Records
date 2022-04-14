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
  internal class ItemReposiory : IItemReposiory
  {
    private ForAccountRecordsDbContext _db;
    public ItemReposiory(ForAccountRecordsDbContext db)
    {
      _db = db;
    }


    public IEntityItems AddNewItem(IEntityItems item)
    {
      _db.Items.Add((DataItem)item);
      _db.SaveChanges();
      return item;
    }

    public IEntityItems EditItem(IEntityItems item)
    {


      _db.Items.Update((DataItem)item);
      _db.SaveChanges();
      return item;
    }

    public IEnumerable<IEntityItems> GetAllItems()
    {
      var items = _db.Items.OrderBy(m => m.DateUploaded);
      return items;
    }

    public IEntityItems GetSingleSpecificItem(int id)
    {
      var item = _db.Items.Find(id);
      return item;
    }
  }
}
