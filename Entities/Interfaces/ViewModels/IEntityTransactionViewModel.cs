using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces.ViewModels
{
  public interface IEntityTransactionViewModel
  {
    IUserDataEEntityTransactions Transaction { get; set; }

    IEnumerable<IUserDataEEntityItems> AllItems { get; set; }

    IEnumerable<IUserDataEntityTransactionType> TransactionTypes { get; set; }

    
  }

  public interface IEntityTransactionGroupViewModel
  {
    IEnumerable<IUserDataEEntityTransactions> Transaction { get; set; }

    IEnumerable<IUserDataEEntityItems> AllItems { get; set; }

    IEnumerable<IUserDataEntityTransactionType> TransactionTypes { get; set; }


  }
}
