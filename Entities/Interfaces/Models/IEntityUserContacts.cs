using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces.Models
{
  public interface IEntityUserContacts : IEntityCoreEntity
  {
    int Id { get; set; }

    string LastName { get; set; }

    string FirstName { get; set; }

    string MiddleName { get; set; }

    string PhoneNumberOne { get; set; }

    string PhoneNumberTwo { get; set; }

    string PhoneNumberThree { get; set; }

    string Email { get; set; }

    string Fax { get; set; }

    string ImageUrl { get; set; }

    string Description { get; set; }

    string Address { get; set; }

     string Website { get; set; }

     string DisplayName { get; set; }
  }
}
