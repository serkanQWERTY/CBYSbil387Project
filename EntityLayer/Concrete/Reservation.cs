using CoreLayer.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservation : IEntity
    {
        public int Id { get; set; }//PK
        public DateTime ReservationTime { get; set; }
        public int ClinicId { get; set; } // FK
        public int DoctorId { get; set; } // FK
        public int PatientId { get; set; } // FK
        public int AssistantId{get; set; } // FK
   
    }
}
