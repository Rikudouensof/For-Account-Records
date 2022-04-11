using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Models
{

  public class DataTransactionType : IEntityTransactionType
  {
    public int Id { get; set; }
    public string Name { get; set; }

    //Relationship

    public DataUser Uploader { get; set; }
    public string UploaderId { get; set; }
  }
}
