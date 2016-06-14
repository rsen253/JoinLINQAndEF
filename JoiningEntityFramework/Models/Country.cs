using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoiningEntityFramework.Models
{
    public class Country
    {
        public Country()
        {
            Students = new List<Student>();
        }
        
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryPin { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}