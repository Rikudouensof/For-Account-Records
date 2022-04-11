using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsInfrastructure.Models
{
  public class DataItem : IEntityItems
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ItemImage { get; set; }

    public DateTime DateUploaded { get; set; }
    public bool isDeleted { get; set; }

    //Relationships

    public DataItemType ItemType { get; set; }
    public int ItemTypeId { get; set; }

    public DataUser Uploader { get; set; }
    public string UploaderId { get; set; }
  }

}
