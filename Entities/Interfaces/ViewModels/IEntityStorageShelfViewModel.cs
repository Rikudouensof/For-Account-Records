using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces.ViewModels
{
  public  interface IEntityStorageShelfViewModel
  {

     IUserDataEEntityStorageShelfs Shelf { get; set; }

     IEnumerable<IUserDataEEntityStorageSpace> StorageSpaces { get; set; }
  }

  public interface IEntityStorageShelfGroupViewModel
  {

    IEnumerable<IUserDataEEntityStorageShelfs> Shelf { get; set; }

    IEnumerable<IUserDataEEntityStorageSpace> StorageSpaces { get; set; }
  }
}
