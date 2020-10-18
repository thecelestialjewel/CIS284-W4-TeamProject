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

        public int Age { get; set; } //age of the dog

        [DataType(DataType.Date)] //will format the date for dog availability
        public DateTime Availability { get; set; }//when the dog will be avaialble for adoption

        [Display(Name = "Adoption Fee")]
        [DataType(DataType.Currency)] //currency formatting
        public decimal AdoptionFee { get; set; }//adoption fee for dog

        [Display(Name = "Are Vaccines Current?")]
        public bool UpToDateVaccinations { get; set; }//if dogs vaccines are up to date
        public string Notes { get; set; }//any notes about the dog
    }

    //REFERENCE:https://stackoverflow.com/questions/46196671/inserting-ef-code-first-seed-data-only-once?fbclid=IwAR10bW6A5y7tzdkKO4XKBQg7KfEF5tHYy6OPAual3vj1ShYHihC56rI3Vmo
    //REFERENCE:https://www.entityframeworktutorial.net/code-first/seed-database-in-code-first.aspx?fbclid=IwAR0Fo3-X54xUKa5pP1_z5U2IHVBpek6Er72CX29dTrzcHgHEQJafgH8sCkQ
    public class RescueDogDbContext : DbContext //inherits from DbConext which is entity framework which talks to database
    {
        //used :base("DogRescueConnection") to prevent creating new connections for each context
        public RescueDogDbContext() : base("DogRescueConnection")//base is Dbcontext constructor specifying connection string.
        {
            Database.SetInitializer(new RescueDogDBInitializer());//calling the data initializer, which will bring up data of dogs
        }
        public DbSet<RescueDog> RescueDogs { get; set; }//rescue dogs table

    }

    public class RescueDogDBInitializer : DropCreateDatabaseAlways<RescueDogDbContext>//working with rescue dog context
    {
        protected override void Seed(RescueDogDbContext context)
        {
            if (!context.RescueDogs.Any())//if nothing in database add these values, if something is in database do not add values
            {
                List<RescueDog> dogs = new List<RescueDog>();
                dogs.Add(new RescueDog { Name = "Eli", Age = 17, AdoptionFee = 500, Availability = DateTime.Now, Breed = "Weimaraner", UpToDateVaccinations = true, Notes = "Needs help with potty training." });
                dogs.Add(new RescueDog { Name = "Winston", Age = 9, AdoptionFee = 150, Availability = DateTime.Now.AddDays(-17), Breed = "Papillon", UpToDateVaccinations = true, Notes = "Nice with children." });
                dogs.Add(new RescueDog { Name = "Ranger", Age = 4, AdoptionFee = 300, Availability = DateTime.Now.AddDays(3), Breed = "German Shepard", UpToDateVaccinations = false, Notes = "Needs a family with yard." });

                context.RescueDogs.AddRange(dogs);

                base.Seed(context);
            }

        }
    }
}