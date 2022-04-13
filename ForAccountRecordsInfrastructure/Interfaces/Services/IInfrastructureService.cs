using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Interfaces.Services
{
  public interface IInfrastructureService
  {

    public IContactsService ContactsRepository { get; set; }

    public IInventoryService InventoryRepository { get; set; }

    public IItemService ItemReposiory { get; set; }

    public IItemTypeService ItemTypeRepository { get; set; }

    public IStorageShelfService StorageShelfRepository { get; set; }

    public IStorageSpaceService StorageSpaceRepository { get; set; }

    public ITransactionsfService TransactionsfRepository { get; set; }

    public ITransactionTypeRepository TransactionTypeRepository { get; set; }
  }
}
