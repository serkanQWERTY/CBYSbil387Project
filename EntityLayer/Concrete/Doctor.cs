﻿using CoreLayer.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Doctor : IEntity
    {
        public int Id { get; set; } // PK
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public int ClinicId { get; set; } //FK
        //public string Email { get; set; }
        //public string Password { get; set; }
        //public string PhoneNumber { get; set; }
        //public string NationalId { get; set; }
    }
}
