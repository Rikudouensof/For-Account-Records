﻿using Entities.Interfaces.Models;
using Entities.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Interfaces.Repository
{

  public interface IStorageShelfRepository
  {
    public IEntityStorageShelfViewModel GetSingleStorageShelf(int Id);

    public IEntityStorageShelfViewModel AddSingleStorageShelf(IEntityStorageShelfs storageShelfs);
    public IEntityStorageShelfViewModel EditStorageShelf(IEntityStorageShelfs storageShelfs);


    public IEntityStorageShelfGroupViewModel GetAllStoraheShelf();

    public IEntityStorageShelfGroupViewModel GetSpecificGroupStorageShelf(string searchTerm, int? storageSpaceId);



  }

}