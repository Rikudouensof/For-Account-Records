using Entities.Interfaces.Models;
using Entities.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Interfaces.Repository
{

  public interface IInventoryRepository
  {
    public IEntityInventory GetSingleSpecificInventory(int id);

    public IEntityInventory AddNewInventory(IEntityInventory inventory);

    public IEntityInventory EditInventory(IEntityInventory inventory);

    public IEnumerable<IEntityInventory> GetAllInventories();

  }
}
