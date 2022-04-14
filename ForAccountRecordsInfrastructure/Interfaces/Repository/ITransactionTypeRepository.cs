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
    public IEntityTransactionType GetSingleSpecificTransactionType(int id);


    public IEnumerable<IEntityTransactionType> GetAllTransactionTypes();




    public IEntityTransactionType AddSingleTransactionType(IEntityTransactionType transactionType);


    public IEntityTransactionType EditTransactionType(IEntityTransactionType transactionType);
  }
}
