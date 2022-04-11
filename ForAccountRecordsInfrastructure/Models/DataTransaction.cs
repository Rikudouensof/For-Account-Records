using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Models
{

  public class DataTransaction : IUserDataEEntityTransactions
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Ammount { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public bool isStationary { get; set; }


    public DateTime DateUploaded { get; set; }
    public bool isDeleted { get; set; }

    //Relationship



    public DataItem Item { get; set; }
    public int ItemId { get; set; }



    public DataTransactionType TransactionType { get; set; }

    public int TransactionTypeId { get; set; }


    public DataUser Uploader { get; set; }
    public string UploaderId { get; set; }
  }
}
