using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces.UserDataViewModel
{
  public interface IUserDataEEntityItems 
  {

    int Id { get; set; }

    string Name { get; set; }

    string Description { get; set; }




    string ItemImage { get; set; }

    int ItemTypeId { get; set; }


  }
}
