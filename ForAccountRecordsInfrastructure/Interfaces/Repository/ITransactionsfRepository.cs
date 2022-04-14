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
    public IEntityTransactions GetSingleTransaction(int id);

    public IEntityTransactions AddSingleTransaction(IEntityTransactions transaction);
    public IEntityTransactions EditTransaction(IEntityTransactions transaction);


    public IEnumerable<IEntityTransactions> GetAllTransactions();


  }
}
