using Microsoft.EntityFrameworkCore;

namespace Banking.API.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Name = "Jack" },
                new Person { Id = 2, Name = "Nick" },
                new Person { Id = 3, Name = "Mary" },
                new Person { Id = 4, Name = "George" },
                new Person { Id = 5, Name = "Jim" });

            modelBuilder.Entity<Account>().HasData(
                new Account { Id = 1, PersonId = 1, Name = "AccountInstance1", Country = 300, Currency = 978, Balance = 68, IsActive = true },
                new Account { Id = 2, PersonId = 1, Name = "AccountInstance2", Country = 300, Currency = 978, Balance = 35, IsActive = true },
                new Account { Id = 3, PersonId = 1, Name = "AccountInstance3", Country = 300, Currency = 978, Balance = 33, IsActive = true },
                new Account { Id = 4, PersonId = 1, Name = "AccountInstance4", Country = 300, Currency = 978, Balance = 125, IsActive = true },
                new Account { Id = 5, PersonId = 1, Name = "AccountInstance5", Country = 300, Currency = 978, Balance = 60, IsActive = true },
                new Account { Id = 6, PersonId = 1, Name = "AccountInstance6", Country = 300, Currency = 978, Balance = 95, IsActive = true },
                new Account { Id = 7, PersonId = 1, Name = "AccountInstance7", Country = 300, Currency = 978, Balance = 65, IsActive = true },
                new Account { Id = 8, PersonId = 1, Name = "AccountInstance8", Country = 300, Currency = 978, Balance = 65, IsActive = true },
                new Account { Id = 9, PersonId = 1, Name = "AccountInstance9", Country = 300, Currency = 978, Balance = 17, IsActive = true },
                new Account { Id = 10, PersonId = 2, Name = "AccountInstance10", Country = 300, Currency = 978, Balance = 99, IsActive = true },
                new Account { Id = 11, PersonId = 2, Name = "AccountInstance11", Country = 300, Currency = 978, Balance = 0, IsActive = false },
                new Account { Id = 12, PersonId = 2, Name = "AccountInstance12", Country = 300, Currency = 978, Balance = 68, IsActive = true },
                new Account { Id = 13, PersonId = 2, Name = "AccountInstance13", Country = 300, Currency = 978, Balance = 125, IsActive = true },
                new Account { Id = 14, PersonId = 2, Name = "AccountInstance14", Country = 300, Currency = 978, Balance = 55, IsActive = true },
                new Account { Id = 15, PersonId = 2, Name = "AccountInstance15", Country = 300, Currency = 978, Balance = 22, IsActive = true },
                new Account { Id = 16, PersonId = 2, Name = "AccountInstance16", Country = 300, Currency = 978, Balance = 95, IsActive = true },
                new Account { Id = 17, PersonId = 2, Name = "AccountInstance17", Country = 300, Currency = 978, Balance = 17, IsActive = true },
                new Account { Id = 18, PersonId = 3, Name = "AccountInstance18", Country = 300, Currency = 978, Balance = 2.8M, IsActive = true },
                new Account { Id = 19, PersonId = 3, Name = "AccountInstance19", Country = 300, Currency = 978, Balance = 2.8M, IsActive = true },
                new Account { Id = 20, PersonId = 3, Name = "AccountInstance20", Country = 300, Currency = 978, Balance = 2.8M, IsActive = true },
                new Account { Id = 21, PersonId = 3, Name = "AccountInstance21", Country = 300, Currency = 978, Balance = 2.8M, IsActive = true },
                new Account { Id = 22, PersonId = 3, Name = "AccountInstance22", Country = 300, Currency = 978, Balance = 2.8M, IsActive = true },
                new Account { Id = 23, PersonId = 3, Name = "AccountInstance23", Country = 300, Currency = 978, Balance = 2.8M, IsActive = true },
                new Account { Id = 24, PersonId = 4, Name = "AccountInstance24", Country = 300, Currency = 978, Balance = 24.99M, IsActive = true },
                new Account { Id = 25, PersonId = 5, Name = "AccountInstance25", Country = 300, Currency = 978, Balance = 9.99M, IsActive = true },
                new Account { Id = 26, PersonId = 5, Name = "AccountInstance26", Country = 300, Currency = 978, Balance = 12.49M, IsActive = true },
                new Account { Id = 27, PersonId = 5, Name = "AccountInstance27", Country = 300, Currency = 978, Balance = 13.99M, IsActive = true },
                new Account { Id = 28, PersonId = 5, Name = "AccountInstance28", Country = 300, Currency = 978, Balance = 12.49M, IsActive = true },
                new Account { Id = 29, PersonId = 5, Name = "AccountInstance29", Country = 300, Currency = 978, Balance = 9.99M, IsActive = true },
                new Account { Id = 30, PersonId = 5, Name = "AccountInstance30", Country = 300, Currency = 978, Balance = 11.99M, IsActive = true },
                new Account { Id = 31, PersonId = 5, Name = "AccountInstance31", Country = 300, Currency = 978, Balance = 12.99M, IsActive = true },
                new Account { Id = 32, PersonId = 5, Name = "AccountInstance32", Country = 300, Currency = 978, Balance = 9.99M, IsActive = true },
                new Account { Id = 33, PersonId = 5, Name = "AccountInstance33", Country = 300, Currency = 978, Balance = 12.49M, IsActive = true });
        }
    }
}
