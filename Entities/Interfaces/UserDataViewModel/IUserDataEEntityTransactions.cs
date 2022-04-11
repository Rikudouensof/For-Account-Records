using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces.UserDataViewModel
{
  public interface IUserDataEEntityTransactions 
  {

    int Id { get; set; }

    string Name { get; set; }

    string Ammount { get; set; }

    string Description { get; set; }

    DateTime Date { get; set; }

    bool isStationary { get; set; }

     int ItemId { get; set; }

     int TransactionTypeId { get; set; }
  }
}
