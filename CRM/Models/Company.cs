using System.Collections.Generic;

namespace CRM.Models
{
    public class Company : Contragent
    {
        public string Name { get; set; }
        public List<Person> Contacts { get; set; }
    }
}
