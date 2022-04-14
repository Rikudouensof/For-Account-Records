﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces.Models
{
  public interface IEntityStorageShelfs : IEntityCoreEntity
  {

    int Id { get; set; }

    string Name { get; set; }

    string Description { get; set; }

    int StrorageSpaceId { get; set; }
  }
}
