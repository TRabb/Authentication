namespace MVCDemo.DataContextMigrations
{
    using MVCDemo.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    internal sealed class Configuration : DbMigrationsConfiguration<MVCDemo.Models.MemberDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataContextMigrations";
        }

        protected override void Seed(MVCDemo.Models.MemberDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var member = new List<Membership>
            {
            new Membership{fname="Barney",lname="Rubble",gender="male", age=50},
            new Membership{fname="Wilma",lname="Flintstone",gender="female", age=45},
            new Membership{fname="Freddie",lname="Flintstone",gender="male", age=50},
            new Membership{fname="Pebbles",lname="Flintstone",gender="female", age=25},
            new Membership{fname="Scooby",lname="Doo",gender="male", age=25}
            };

            member.ForEach(m => context.Members.AddOrUpdate(m));
            context.SaveChanges();
        }
    }
}
