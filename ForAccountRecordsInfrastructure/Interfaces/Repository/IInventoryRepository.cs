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

    public IEntityInventoryViewModel AddNewInventory(IUserDataEEntityInventory inventory);

    public IEntityInventoryViewModel EditInventory(IUserDataEEntityInventory inventory);

    public IEntityInventoryGroupViewModel GetAllInventories();

    public IEntityInventoryGroupViewModel GetSpecificGroupInventories(string searchTerm, int? itemId);
  }
}
