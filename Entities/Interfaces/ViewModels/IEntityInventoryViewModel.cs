using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces.ViewModels
{
  public interface IEntityInventoryViewModel
  {

    IUserDataEEntityInventory Inventory { get; set; }

    IEnumerable<IUserDataEEntityItems> AllItems { get; set; }
  }

  public interface IEntityInventoryGroupViewModel
  {
    IEnumerable<IUserDataEEntityInventory> Inventory { get; set; }

    IEnumerable<IUserDataEEntityItems> AllItems { get; set; }
  }
}
