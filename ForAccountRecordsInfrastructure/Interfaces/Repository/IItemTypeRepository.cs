using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Interfaces.Repository
{

  public interface IItemTypeRepository
  {
    public IUserDataEEntityItemType GetSingleSpecificItemType(int id);


    public IEnumerable<IUserDataEEntityItemType> GetAllItemType();

    public IEnumerable<IUserDataEEntityItemType> GetSearchedItemType(string searchTerm);



    public IUserDataEEntityItemType AddSingleItemType(IUserDataEEntityItemType itemType);


    public IUserDataEEntityItemType EditItemType(IUserDataEEntityItemType itemType);
  }
}
