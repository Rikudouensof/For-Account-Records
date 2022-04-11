using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces.ViewModels
{
  public interface IEntityItemViewModel
  {

     IEntityItems Item { get; set; }
     IEnumerable<IEntityItemType> ItemTypes { get; set; }
  }
}
