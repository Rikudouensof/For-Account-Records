using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces.Models
{
  public interface IEntityTransactionType : IEntityCoreEntity
  {

    int Id { get; set; }

    string Name { get; set; }

  }
}
