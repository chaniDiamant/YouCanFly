using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YouCanFly.Models
{
    public class PlaneDepartment
    {//לשנות שם של מחלקת classId
        [Key]
        public int PlanesId { get; set; }
        public Planes Plane { get; set; }
       
        public int DepartmentId { get; set; }
     
        public Department department { get; set; }
    }
}
