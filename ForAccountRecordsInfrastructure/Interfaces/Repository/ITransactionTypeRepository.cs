using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Interfaces.Repository
{
  public interface ITransactionTypeRepository
  {
    public IUserDataEntityTransactionType GetSingleSpecificTransactionType(int id);


    public IEnumerable<IUserDataEntityTransactionType> GetAllTransactionTypes();


    public IEnumerable<IUserDataEntityTransactionType> GetSearchedTransactionTypes(string searchTerm);


    public IUserDataEntityTransactionType AddSingleTransactionType(IUserDataEntityTransactionType transactionType);


    public IUserDataEntityTransactionType EditTransactionType(IUserDataEntityTransactionType transactionType);
  }
}
