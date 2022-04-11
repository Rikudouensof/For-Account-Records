using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Models
{

  public class DataStorageSpace : IEntityStorageSpace
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateUploaded { get; set; }
    public bool isDeleted { get; set; }

    //Relationship

    public DataUser Uploader { get; set; }
    public string UploaderId { get; set; }
  }
}
