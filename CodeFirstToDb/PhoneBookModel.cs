namespace CodeFirstToDb
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    using Data.Models;

    public class PhoneBookModel : DbContext
    {
        // Your context has been configured to use a 'PhoneBookModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirstToDb.PhoneBookModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PhoneBookModel' 
        // connection string in the application configuration file.
        public PhoneBookModel()
            : base("name=PhoneBookModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        //public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Male> Males { get; set; }
        public virtual DbSet<Female> Females { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //turn off delete cascading on linking tables
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();


            ////Set up a many to many table that isn't represented as a module
            //modelBuilder.Entity<Person>().HasMany(c => c.Phones);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}