using ForAccountRecordsCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAccountRecordsCore.Data
{
  public class ForAccountRecordsDbContext : IdentityDbContext<DataUser>
  {
    public ForAccountRecordsDbContext(DbContextOptions<ForAccountRecordsDbContext> options) : base(options)
    {

    }

    public DbSet<DataContacts> Contacts { get; set; }

    public DbSet<DataInventory> Inventories { get; set; }

    public DbSet<DataItem> Items { get; set; }

    public DbSet<DataItemType> ItemTypes { get; set; }

    public DbSet<DataStorageShelf> StorageShelf { get; set; }

    public DbSet<DataTransaction> Transactions { get; set; }

    public DbSet<DataTransactionType> TransactionTypes { get; set; }

  }
}
