using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces.Models
{
  public interface IEntityInventory : IEntityCoreEntity
  {
    int Id { get; set; }
    decimal PurchacePrice { get; set; }

    decimal SellingPrice { get; set; }

    DateTime ManufactureDate { get; set; }

    DateTime ExpiryDate { get; set; }

    int ItemId { get; set; }

    int Quantity { get; set; }

    string Description { get; set; }
  }
}
