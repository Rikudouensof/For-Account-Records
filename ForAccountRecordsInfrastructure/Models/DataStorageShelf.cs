using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Models
{

  public class DataStorageShelf : IUserDataEEntityStorageShelfs
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public DateTime DateUploaded { get; set; }
    public bool isDeleted { get; set; }

    //Relationships

    public DataStorageSpace StrorageSpace { get; set; }
    public int StrorageSpaceId { get; set; }

    public DataUser Uploader { get; set; }
    public string UploaderId { get; set; }
  }

}
