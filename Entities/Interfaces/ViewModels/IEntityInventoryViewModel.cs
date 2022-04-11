using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces.ViewModels
{
  public interface IEntityInventoryViewModel
  {

    IEntityInventory Inventory { get; set; }

    IEnumerable<IEntityItems> AllItems { get; set; }
  }

  public interface IEntityInventoryGroupViewModel
  {
    IEnumerable<IEntityInventory> Inventory { get; set; }

    IEnumerable<IEntityItems> AllItems { get; set; }
  }
}
