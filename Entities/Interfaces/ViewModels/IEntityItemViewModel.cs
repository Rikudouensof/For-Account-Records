using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces.ViewModels
{
  public interface IEntityItemViewModel
  {

     IUserDataEEntityItems Item { get; set; }
     IEnumerable<IUserDataEEntityItemType> ItemTypes { get; set; }
  }


  public interface IEntityItemGroupViewModel
  {

    IEnumerable<IUserDataEEntityItems> Items { get; set; }
    IEnumerable<IUserDataEEntityItemType> ItemTypes { get; set; }
  }
}
