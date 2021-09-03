using System;

namespace CRM.Models.Dtos
{
    public class CompanyDto
    {
        public string Name {  get; set; }
        public DateTime CreatedDate {  get; set; }
        public string TaxNumber { get; set; }
        public int ContactsCount {  get; set; }
    }
}
