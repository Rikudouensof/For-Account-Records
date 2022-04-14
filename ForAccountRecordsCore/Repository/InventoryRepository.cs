using Entities.Interfaces.Models;
using Entities.Interfaces.ViewModels;
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
  internal class InventoryRepository : IInventoryRepository
  {
    private ForAccountRecordsDbContext _db;
    public InventoryRepository(ForAccountRecordsDbContext db)
    {
      _db = db;
    }
    public IEntityInventory AddNewInventory(IEntityInventory inventory)
    {
      _db.Inventories.Add((DataInventory)inventory);
      _db.SaveChanges();
      return inventory;
    }

    public IEntityInventory EditInventory(IEntityInventory inventory)
    {
      _db.Inventories.Update((DataInventory)inventory);
      _db.SaveChanges();
      return inventory;
    }

    public IEnumerable<IEntityInventory> GetAllInventories()
    {
      var inventories = _db.Inventories.OrderBy(m => m.ExpiryDate);
      return inventories;
    }

    public IEntityInventory GetSingleSpecificInventory(int id)
    {
      var inventory = _db.Inventories.Find(id);
      return inventory;
    }
  }
}
