using System.ComponentModel;

namespace SimpleMVC.Models
{
    public class Contact
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Surname")]
        public string Surname { get; set; }

        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("City")]
        public string City { get; set; }

        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
