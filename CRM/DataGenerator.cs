using CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRM
{
    public class DataGenerator
    {
        private readonly Random _random = new Random();
        public List<Person> Contacts()
        {
            var contacts = new List<Person>
            {
                new Person { LastName = "Smirnov", FirstName = "Ivan", MiddleName = "Ivanovich", Position = "CTO"},
                new Person { LastName = "Petrov", FirstName = "Michail", MiddleName = "Dmitrievich", Position = "CEO"},
                new Person { LastName = "Alekseev", FirstName = "Sergey", MiddleName = "Alexandrovich", Position = "Manager"},
                new Person { LastName = "Shevchenko", FirstName = "Petr", MiddleName = "Ivanovich", Position = "CTO"},
                new Person { LastName = "Alekseev", FirstName = "Petr", MiddleName = "Dmitrievich", Position = "CEO"},
                new Person { LastName = "Smirnov", FirstName = "Michail", MiddleName = "Alexandrovich", Position = "Manager"},
                new Person { LastName = "Shevchenko", FirstName = "Ivan", MiddleName = "Ivanovich", Position = "CTO"},
                new Person { LastName = "Smirnov", FirstName = "Petr", MiddleName = "Dmitrievich", Position = "CEO"},
                new Person { LastName = "Alekseev", FirstName = "Michail", MiddleName = "Ivanovich", Position = "Manager"},
                new Person { LastName = "Petrov", FirstName = "Petr", MiddleName = "Alexandrovich", Position = "CEO"},
                new Person { LastName = "Shevchenko", FirstName = "Michail", MiddleName = "Alexandrovich", Position = "Manager"},
                new Person { LastName = "Borisov", FirstName = "Ivan", MiddleName = "Dmitrievich", Position = "CEO"},
                new Person { LastName = "Alekseev", FirstName = "Michail", MiddleName = "Alexandrovich", Position = "Manager"}
            };

            var id = 1;
            contacts.ForEach(c =>
            {
                c.Id = id++;
                c.TaxNumber = _random.Next(10000, 99999).ToString();
                c.PhoneNumber = $"+7707{_random.Next(1000000, 9990000)}";
                c.CreatedDate = DateTime.UtcNow;
                c.AuthorCreated = "Moderator";
                c.CompanyId = _random.Next(1, 7);
            });

            return contacts;
        }

        public List<Company> NewData()
        {
            var companies = new List<Company>
            {
                new Company { Id = 1, Name = "AO STD", Contacts = Contacts().Where(c => c.CompanyId == 1).ToList()},
                new Company { Id = 2, Name = "TOO Grand", Contacts = Contacts().Where(c => c.CompanyId == 2).ToList()},
                new Company { Id = 3, Name = "AO LTS", Contacts = Contacts().Where(c => c.CompanyId == 3).ToList()},
                new Company { Id = 4, Name = "AO Vector", Contacts = Contacts().Where(c => c.CompanyId == 4).ToList()},
                new Company { Id = 5, Name = "TOO Lanta", Contacts = Contacts().Where(c => c.CompanyId == 5).ToList()},
                new Company { Id = 6, Name = "TOO Nord", Contacts = Contacts().Where(c => c.CompanyId == 6).ToList()},
                new Company { Id = 7, Name = "AO West", Contacts = Contacts().Where(c => c.CompanyId == 7).ToList()}
            };

            companies.ForEach(c =>
            {
                c.CreatedDate = c.CreatedDate = DateTime.UtcNow;
                c.AuthorCreated = "Moderator";
                c.TaxNumber = _random.Next(100000, 999999).ToString();
            });

            return companies;
        }
    }
}
