using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces.ViewModels
{
  public  interface IEntityStorageShelfViewModel
  {

     IEntityStorageShelfs Shelf { get; set; }

     IEnumerable<IEntityStorageSpace> StorageSpaces { get; set; }
  }
}
