using System;
using System.ComponentModel.DataAnnotations;

namespace EF_Library
{
    class Client
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Passport { get; set; }
        public DateTime registrationDate { get; set; }
        
        public Client() { }
        public Client(string fullName, string phone, string passport)
        {
            FullName = fullName;
            Phone = phone;
            Passport = passport;
            registrationDate = DateTime.Now;
        }
    }
}
