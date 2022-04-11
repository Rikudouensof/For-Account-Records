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
    public IEntityTransactionViewModel GetSingleTransaction(int Id);

    public IEntityTransactionViewModel AddSingleTransaction(IEntityTransactions storageShelfs);
    public IEntityTransactionViewModel EditTransaction(IEntityTransactions storageShelfs);


    public IEntityTransactionGroupViewModel GetAllTransactions();

    public IEntityTransactionGroupViewModel GetSpecificGroupTransactions(string searchTerm, int? storageSpaceId);

  }
}
