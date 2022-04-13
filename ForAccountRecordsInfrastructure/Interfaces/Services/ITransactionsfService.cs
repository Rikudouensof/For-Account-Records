using Entities.Interfaces.Models;
using Entities.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Interfaces.Services
{
  public interface ITransactionsfService
  {
    public IEntityTransactionViewModel GetSingleTransaction(int Id);

    public IEntityTransactionViewModel AddSingleTransaction(IUserDataEEntityTransactions storageShelfs);
    public IEntityTransactionViewModel EditTransaction(IUserDataEEntityTransactions storageShelfs);


    public IEntityTransactionGroupViewModel GetAllTransactions();

    public IEntityTransactionGroupViewModel GetSpecificGroupTransactions(string searchTerm, int? storageSpaceId);

  }
}
