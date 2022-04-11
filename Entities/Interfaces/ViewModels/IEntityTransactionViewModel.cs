using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces.ViewModels
{
  public interface IEntityTransactionViewModel
  {
    IEntityTransactions Transaction { get; set; }

    IEnumerable<IEntityItems> AllItems { get; set; }

    IEnumerable<IEntityTransactionType> TransactionTypes { get; set; }

    
  }

  public interface IEntityTransactionGroupViewModel
  {
    IEnumerable<IEntityTransactions> Transaction { get; set; }

    IEnumerable<IEntityItems> AllItems { get; set; }

    IEnumerable<IEntityTransactionType> TransactionTypes { get; set; }


  }
}
