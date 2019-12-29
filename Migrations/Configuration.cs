namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Vidly.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidly.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Vidly.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.MembershipTypes.AddOrUpdate(new MembershipType() { Id = 1, Name = "No Membership", DurationInMonths = 0, SignUpFee = 3, DiscountRate = 0 },
                new MembershipType() { Id = 2, Name = "Monthly", DurationInMonths = 1, SignUpFee = 30, DiscountRate = 10 },
                new MembershipType() { Id = 3, Name = "Quarterly", DurationInMonths = 3, SignUpFee = 90, DiscountRate = 15 },
                new MembershipType() { Id = 4, Name = "Yearly", DurationInMonths = 12, SignUpFee = 300, DiscountRate = 20 });

            context.Customers.AddOrUpdate(new Customer() { Id = 1, Name = "John Smith", isSubscribedToNewsletter = false, MembershipTypeId = 1, Birthday = new DateTime(2003, 5, 23)},
                new Customer() { Id = 2, Name = "Mary Williams", isSubscribedToNewsletter = false, MembershipTypeId = 2, Birthday = new DateTime(1993, 12, 24)});

            context.Movies.AddOrUpdate(new Movie() { Name = "Shrek", GenreId = 5, ReleaseDate = new DateTime(2001, 4, 22), DateAdded = DateTime.Now, Stock = 6 },
                new Movie() { Name = "Frozen 2", GenreId = 5, ReleaseDate = new DateTime(2019, 11, 22), DateAdded = DateTime.Now, Stock = 11 },
            new Movie() { Name = "Star Wars: The Last Jedi", GenreId = 1, ReleaseDate = new DateTime(2017, 12, 15), DateAdded = DateTime.Now, Stock = 9 },
            new Movie() { Name = "Balls Of Fury", GenreId = 2, ReleaseDate = new DateTime(2007, 10, 29), DateAdded = DateTime.Now, Stock = 2},
            new Movie() { Name = "Mamma Mia!", GenreId = 6, ReleaseDate = new DateTime(2008, 6, 30), DateAdded = DateTime.Now, Stock = 3 });

            context.Genres.AddOrUpdate(new Genre() { Name = "Action" },
                new Genre { Name = "Comedy" },
                new Genre { Name = "Drama" },
                new Genre { Name = "Romance" },
                new Genre { Name = "Kids" },
                new Genre { Name = "Musical" },
                new Genre { Name = "Documentary" },
                new Genre { Name = "Anime" },
                new Genre { Name = "Horror" });
        }
    }
}
