using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces.Models
{
  public interface IEntityCoreEntity
  {
    string UploaderId { get; set; }

    DateTime DateUploaded { get; set; }

    bool isDeleted { get; set; }
  }
}
