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
    public IEntityItems GetSingleSpecificItem(int id);

    public IEntityItems AddNewItem(IEntityItems item);
    public IEntityItems EditItem(IEntityItems item);

    public IEnumerable<IEntityItems> GetAllItems();


  }

}
