using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Interfaces.Services
{
  public interface ITransactionTypeService
  {
    public IUserDataEntityTransactionType GetSingleSpecificTransactionType(int id);


    public IEnumerable<IUserDataEntityTransactionType> GetAllTransactionTypes();


    public IEnumerable<IUserDataEntityTransactionType> GetSearchedTransactionTypes(string searchTerm);


    public IUserDataEntityTransactionType AddSingleTransactionType(IUserDataEntityTransactionType transactionType);


    public IUserDataEntityTransactionType EditTransactionType(IUserDataEntityTransactionType transactionType);
  }
}
