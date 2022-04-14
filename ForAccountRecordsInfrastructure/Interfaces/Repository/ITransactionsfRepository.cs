using Entities.Interfaces.Models;
using Entities.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Interfaces.Repository
{
  public interface ITransactionsfRepository
  {
    public IEntityTransactions GetSingleTransaction(int Id);

    public IEntityTransactions AddSingleTransaction(IEntityTransactions storageShelfs);
    public IEntityTransactions EditTransaction(IEntityTransactions storageShelfs);


    public IEnumerable<IEntityTransactions> GetAllTransactions();


  }
}
