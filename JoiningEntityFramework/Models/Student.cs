using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoiningEntityFramework.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public int CountryId { get; set; }
        public int RoomId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Email { get; set; }

        public virtual Country Country  { get; set; }
        public virtual Room Room { get; set; }
    }

}