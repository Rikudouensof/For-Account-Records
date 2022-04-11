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
    public IEntityInventoryViewModel GetSingleSpecificInventory(int id);

    public IEntityInventoryViewModel AddNewInventory(IEntityInventory inventory);

    public IEntityInventoryViewModel EditInventory(IEntityInventory inventory);

    public IEntityInventoryGroupViewModel GetAllInventories();

    public IEntityInventoryGroupViewModel GetSpecificGroupInventories(string searchTerm, int? itemId);
  }
}
