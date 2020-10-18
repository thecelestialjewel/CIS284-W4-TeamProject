using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace DogRescue.Models
{
    public class RescueDog //building model for the dog that's available for adoption
    {
        
        public int Id { get; set; } //dog id 
        public string Name { get; set; } //name of the dog
        public string Breed { get; set; } //breed of the dog

        [DisplayFormat(DataFormatString = "0 yr(s)")] //will format the dogs age in years
        public int Age { get; set; } //age of the dog

        [DataType(DataType.Date)] //will format the date for dog availability
        public DateTime Availability { get; set; }//when the dog will be avaialble for adoption

        [Display(Name ="Adoption Fee")]
        [DataType(DataType.Currency)] //currency formatting
        public decimal AdoptionFee { get; set; }//adoption fee for dog

        [Display(Name = "Are Vaccines Current?")]
        public bool UpToDateVaccinations { get; set; }//if dogs vaccines are up to date
        public string Notes { get; set; }//any notes about the dog
    }

    public class RescueDogDbContext:DbContext //inherits from DbConext which is entity framework which talks to database
    {
        //used :base("DogRescueConnection") to prevent creating new connections for each context
        public RescueDogDbContext():base("DogRescueConnection")//base is Dbcontext constructor specifying connection string.
        {

        }
        public DbSet<RescueDog> RescueDogs { get; set; }//rescue dogs table

    }
}