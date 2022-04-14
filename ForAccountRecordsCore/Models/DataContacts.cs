using Entities.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsCore.Models
{

  public class DataContacts : IEntityUserContacts
  {
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string PhoneNumberOne { get; set; }
    public string PhoneNumberTwo { get; set; }
    public string PhoneNumberThree { get; set; }
    public string Email { get; set; }
    public string Fax { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public DateTime DateUploaded { get; set; }
    public bool isDeleted { get; set; }
    public string Website { get; set; }
    public string DisplayName { get; set; }

    //Relationship

    public DataUser Uploader { get; set; }
    public string UploaderId { get; set; }
  }
}
