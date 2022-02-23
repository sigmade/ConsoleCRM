using CRM.Models;
using CRM.Models.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CRM
{
    class Program
    {
        private readonly static string _filePath = "CRM.json";

        static void Main()
        {
            var fileExtension = Path.GetExtension(_filePath);

            if(fileExtension != ".json")
            {
                throw new FileFormatException("The file must be in json format");
            }

            WriteData();

            var query = from companies in ReadData()
                        from contacts in companies.Contacts
                        orderby contacts.LastName, contacts.FirstName, contacts.MiddleName
                        select contacts;

            foreach (var c in query)
            {
                Console.WriteLine($"{c.LastName} {c.FirstName} {c.MiddleName}\n" + 
                    $"Position - {c.Position}. TaxNumber - {c.TaxNumber}. Phone - {c.PhoneNumber}\n ");
            }

            var topCompany = ReadData()
                    .OrderByDescending(c => c.Contacts.Count())
                    .Take(5)
                    .Select(c => new CompanyDto 
                    { 
                        Name = c.Name,
                        CreatedDate = c.CreatedDate,
                        TaxNumber = c.TaxNumber,
                        ContactsCount = c.Contacts.Count()
                    });

            foreach (var c in topCompany)
            {
                Console.WriteLine($"'{c.Name}'. Counts contacts " + 
                    $"{c.ContactsCount}. TaxNumber - {c.TaxNumber}\n ");
            }

            Console.ReadKey();
        }

        static List<Company> ReadData()
        {
            var content = "";

            using (var reader = new StreamReader(_filePath))
            {
                content = reader.ReadToEnd();
            }

            var data = JsonConvert.DeserializeObject<List<Company>>(content);

            return data;
        }

        static void WriteData()
        {
            var data = new DataGenerator();
            var objToWrite = JsonConvert.SerializeObject(data.NewData());
            using (var writer = new StreamWriter(_filePath, false))
            {
                writer.Write(objToWrite);
            }
        }
    }
}
