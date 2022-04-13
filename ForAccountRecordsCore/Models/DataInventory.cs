using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsCore.Models
{
  public class DataInventory : IUserDataEEntityInventory
  {
    public int Id { get; set; }
    public decimal PurchacePrice { get; set; }
    public decimal SellingPrice { get; set; }
    public DateTime ManufactureDate { get; set; }
    public DateTime ExpiryDate { get; set; }

   
    public int Quantity { get; set; }
    public string Description { get; set; }

   
    public DateTime DateUploaded { get; set; }
    public bool isDeleted { get; set; }

    //Relationships

    public DataItem Item { get; set; }
    public int ItemId { get; set; }

    public DataUser Uploader { get; set; }
    public string UploaderId { get; set; }
  }

  






}
