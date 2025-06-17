namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CodeFirst.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirst.Models.ApplicationDbContext context)
        {
            // Seed Gender Data
            context.Genders.AddOrUpdate(
                g => g.Name, // Avoid duplicate entries
                new Gender { GenderID = 1, Name = "Male" },
                new Gender { GenderID = 2, Name = "Female" },
                new Gender { GenderID = 3, Name = "Other" }
            );

            
            context.Countries.AddOrUpdate(
                c => c.Name,
                new Country { CountryID = 1, Name = "United States" },
                new Country { CountryID = 2, Name = "Canada" },
                new Country { CountryID = 3, Name = "United Kingdom" },
                new Country { CountryID = 4, Name = "India"}
            );

            
            context.States.AddOrUpdate(
                s => s.Name,
                //new State { StateID = 1, Name = "California", CountryID = 1 },
                //new State { StateID = 2, Name = "New York", CountryID = 1 },
                //new State { StateID = 3, Name = "Ontario", CountryID = 2 },
                //new State { StateID = 4, Name = "Quebec", CountryID = 2 },
                //new State { StateID = 5, Name = "London", CountryID = 3 },
new State { StateID = 6, Name = "Maharashtra", CountryID = 4 },
new State { StateID = 7, Name = "Andhra Pradesh", CountryID = 4 },
new State { StateID = 8, Name = "Arunachal Pradesh", CountryID = 4 },
new State { StateID = 9, Name = "Assam", CountryID = 4 },
new State { StateID = 10, Name = "Bihar", CountryID = 4 },
new State { StateID = 11, Name = "Chhattisgarh", CountryID = 4 },
new State { StateID = 12, Name = "Goa", CountryID = 4 },
new State { StateID = 13, Name = "Gujarat", CountryID = 4 },
new State { StateID = 14, Name = "Haryana", CountryID = 4 },
new State { StateID = 15, Name = "Himachal Pradesh", CountryID = 4 },
new State { StateID = 16, Name = "Jharkhand", CountryID = 4 },
new State { StateID = 17, Name = "Karnataka", CountryID = 4 },
new State { StateID = 18, Name = "Kerala", CountryID = 4 },
new State { StateID = 19, Name = "Madhya Pradesh", CountryID = 4 },
new State { StateID = 20, Name = "Maharashtra", CountryID = 4 },
new State { StateID = 21, Name = "Manipur", CountryID = 4 },
new State { StateID = 22, Name = "Meghalaya", CountryID = 4 },
new State { StateID = 23, Name = "Mizoram", CountryID = 4 },
new State { StateID = 24, Name = "Nagaland", CountryID = 4 },
new State { StateID = 25, Name = "Odisha", CountryID = 4 },
new State { StateID = 26, Name = "Punjab", CountryID = 4 },
new State { StateID = 27, Name = "Rajasthan", CountryID = 4 },
new State { StateID = 28, Name = "Sikkim", CountryID = 4 },
new State { StateID = 29, Name = "Tamil Nadu", CountryID = 4 },
new State { StateID = 30, Name = "Telangana", CountryID = 4 },
new State { StateID = 31, Name = "Tripura", CountryID = 4 },
new State { StateID = 32, Name = "Uttar Pradesh", CountryID = 4 },
new State { StateID = 33, Name = "Uttarakhand", CountryID = 4 },
new State { StateID = 34, Name = "West Bengal", CountryID = 4 },


new State { StateID = 35, Name = "England", CountryID = 3 },
new State { StateID = 36, Name = "Scotland", CountryID = 3 },
new State { StateID = 37, Name = "Wales", CountryID = 3 },
new State { StateID = 38, Name = "Northern Ireland", CountryID = 3 },

new State { StateID = 39, Name = "Alabama", CountryID = 1 },
new State { StateID = 40, Name = "Alaska", CountryID = 1 },
new State { StateID = 41, Name = "Arizona", CountryID = 1 },
new State { StateID = 42, Name = "Arkansas", CountryID = 1 },
new State { StateID = 43, Name = "California", CountryID = 1 },
new State { StateID = 44, Name = "Colorado", CountryID = 1 },
new State { StateID = 45, Name = "Connecticut", CountryID = 1 },
new State { StateID = 46, Name = "Delaware", CountryID = 1 },
new State { StateID = 47, Name = "Florida", CountryID = 1 },
new State { StateID = 48, Name = "Georgia", CountryID = 1 },
new State { StateID = 49, Name = "Hawaii", CountryID = 1 },
new State { StateID = 50, Name = "Idaho", CountryID = 1 },
new State { StateID = 51, Name = "Illinois", CountryID = 1 },
new State { StateID = 52, Name = "Indiana", CountryID = 1 },
new State { StateID = 53, Name = "Iowa", CountryID = 1 },
new State { StateID = 54, Name = "Kansas", CountryID = 1 },
new State { StateID = 55, Name = "Kentucky", CountryID = 1 },
new State { StateID = 56, Name = "Louisiana", CountryID = 1 },
new State { StateID = 57, Name = "Maine", CountryID = 1 },
new State { StateID = 58, Name = "Maryland", CountryID = 1 },


new State { StateID = 89, Name = "Alberta", CountryID = 2 },
new State { StateID = 90, Name = "British Columbia", CountryID = 2 },
new State { StateID = 91, Name = "Manitoba", CountryID = 2 },
new State { StateID = 92, Name = "New Brunswick", CountryID = 2 },
new State { StateID = 93, Name = "Newfoundland and Labrador", CountryID = 2 },
new State { StateID = 94, Name = "Northwest Territories", CountryID = 2 },
new State { StateID = 95, Name = "Nova Scotia", CountryID = 2 },
new State { StateID = 96, Name = "Nunavut", CountryID = 2 },
new State { StateID = 97, Name = "Ontario", CountryID = 2 },
new State { StateID = 98, Name = "Prince Edward Island", CountryID = 2 },
new State { StateID = 99, Name = "Quebec", CountryID = 2 },
new State { StateID = 100, Name = "Saskatchewan", CountryID = 2 },
new State { StateID = 101, Name = "Yukon", CountryID = 2 }


            );

            context.SaveChanges(); 
        }
    }
}
