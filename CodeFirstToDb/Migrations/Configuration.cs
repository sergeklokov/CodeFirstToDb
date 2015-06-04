namespace CodeFirstToDb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Data.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstToDb.PhoneBookModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstToDb.PhoneBookModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Females.AddOrUpdate(
                f => f.PersonID,
                new Female{ Name ="Diana", PersonID = 1});

            context.Males.AddOrUpdate(
                m => m.PersonID,
                new Male { Name = "Serge", PersonID = 2 },
                new Male { Name = "Brice", PersonID = 3 },
                new Male { Name = "Andrew", PersonID = 4 });


            context.Phones.AddOrUpdate(
                t => t.Number,
                    new Phone { Number = "1110", PersonID = 1},
                    new Phone { Number = "1112", PersonID = 1 },
                    new Phone { Number = "2220", PersonID = 2 },
                    new Phone { Number = "3330", PersonID = 3 }
                );

            context.Males.AddOrUpdate(m => m.PersonID,
                new Male { PersonID = 5, Name = "Tony" });
        }
    }
}
