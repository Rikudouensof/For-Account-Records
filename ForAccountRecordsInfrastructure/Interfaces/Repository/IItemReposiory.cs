using Entities.Interfaces.Models;
using Entities.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Interfaces.Repository
{

  public interface IItemReposiory
  {
    public IEntityItemViewModel GetSingleSpecificItem(int id);

    public IEntityItemViewModel AddNewItem(IUserDataEEntityItems item);
    public IEntityItemViewModel EditItem(IUserDataEEntityItems item);

    public IEntityItemGroupViewModel GetAllItems();

    public IEntityItemGroupViewModel GetSpecificItemGroup(string searchTerm, int? itemTypeId);

  }

}
