﻿using System;
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
        public DateTime RegistrationDate { get; set; }
        //public string Adress { get; set; }
    }
}
