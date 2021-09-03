using System;

namespace CRM.Models
{
    public abstract class Contragent
    {
        public int Id { get; set; }
        public string TaxNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public string AuthorCreated { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string AutorModified { get; set; }
    }
}
