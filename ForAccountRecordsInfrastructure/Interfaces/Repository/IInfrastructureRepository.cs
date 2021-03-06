using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Interfaces.Repository
{
  public interface IInfrastructureRepository
  {

    public IContactsRepository ContactsRepository { get; set; }

    public IInventoryRepository InventoryRepository { get; set; }

    public IItemReposiory ItemReposiory { get; set; }

    public IItemTypeRepository ItemTypeRepository { get; set; }

    public IStorageShelfRepository StorageShelfRepository { get; set; }

    public IStorageSpaceRepository StorageSpaceRepository { get; set; }

    public ITransactionsfRepository TransactionsfRepository { get; set; }

    public ITransactionTypeRepository TransactionTypeRepository { get; set; }
  }
}
