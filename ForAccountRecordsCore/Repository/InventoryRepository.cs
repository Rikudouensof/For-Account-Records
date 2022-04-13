using Entities.Interfaces.Models;
using Entities.Interfaces.ViewModels;
using ForAccountRecordsCore.Data;
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
    public IEntityInventoryViewModel AddNewInventory(IUserDataEEntityInventory inventory)
    {
      throw new NotImplementedException();
    }

    public IEntityInventoryViewModel EditInventory(IUserDataEEntityInventory inventory)
    {
      throw new NotImplementedException();
    }

    public IEntityInventoryGroupViewModel GetAllInventories()
    {
      throw new NotImplementedException();
    }

    public IEntityInventoryViewModel GetSingleSpecificInventory(int id)
    {
      throw new NotImplementedException();
    }
  }
}
