namespace CRM.Models
{
    public class Person : Contragent
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
        public int CompanyId { get; set; }
    }
}
