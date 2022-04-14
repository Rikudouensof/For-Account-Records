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
    public IEntityItemType GetSingleSpecificItemType(int id);


    public IEnumerable<IEntityItemType> GetAllItemType();




    public IEntityItemType AddSingleItemType(IEntityItemType itemType);


    public IEntityItemType EditItemType(IEntityItemType itemType);
  }
}
