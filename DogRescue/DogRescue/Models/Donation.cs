using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DogRescue.Models
{
    public class Donation //model that holds donation information
    {
        public int Id { get; set; }//autoproperty
        public string Donator { get; set; } //autoproperty for person who donates
        public decimal Amount { get; set; } //autoproperty for donaton amount
    }

    public class DonationsDbContext : DbContext //how donations communicates with database
    {
        public DbSet<Donation> Donations { get; set; }//C# representation of donations database
    }
}