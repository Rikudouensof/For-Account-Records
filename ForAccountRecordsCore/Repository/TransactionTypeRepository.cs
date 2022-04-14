using Entities.Interfaces.Models;
using ForAccountRecordsCore.Data;
using ForAccountRecordsCore.Models;
using ForAccountRecordsInfrastructure.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsCore.Repository
{
  internal class TransactionTypeRepository : ITransactionTypeRepository
  {

    private ForAccountRecordsDbContext _db;
    public TransactionTypeRepository(ForAccountRecordsDbContext db)
    {
      _db = db;
    }
    public IEntityTransactionType AddSingleTransactionType(IEntityTransactionType transactionType)
    {
      _db.TransactionTypes.Add((DataTransactionType)transactionType);
      _db.SaveChanges();
      return transactionType;
    }

    public IEntityTransactionType EditTransactionType(IEntityTransactionType transactionType)
    {
      _db.TransactionTypes.Add((DataTransactionType)transactionType);
      _db.SaveChanges();
      return transactionType;
    }

    public IEnumerable<IEntityTransactionType> GetAllTransactionTypes()
    {
      var transactionTypes = _db.TransactionTypes.OrderByDescending(m => m.DateUploaded);
      return transactionTypes;
    }

    public IEntityTransactionType GetSingleSpecificTransactionType(int id)
    {
      var transactionType = _db.TransactionTypes.Find(id);
      return transactionType;
    }
  }
}
