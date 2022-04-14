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
  internal class TransactionsfRepository : ITransactionsfRepository
  {

    private ForAccountRecordsDbContext _db;
    public TransactionsfRepository(ForAccountRecordsDbContext db)
    {
      _db = db;
    }



    public IEntityTransactions AddSingleTransaction(IEntityTransactions transaction)
    {
      _db.Transactions.Add((DataTransaction)transaction);
      _db.SaveChanges();
      return transaction;
    }

    public IEntityTransactions EditTransaction(IEntityTransactions transaction)
    {
      _db.Transactions.Add((DataTransaction)transaction);
      _db.SaveChanges();
      return transaction;
    }

    public IEnumerable<IEntityTransactions> GetAllTransactions()
    {
      var transactions = _db.Transactions.OrderByDescending(m => m.DateUploaded);
      return transactions;
    }

    public IEntityTransactions GetSingleTransaction(int id)
    {
      var transaction = _db.Transactions.Find(id);
      return transaction;
    }
  }
}
