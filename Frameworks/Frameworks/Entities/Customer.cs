using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks.Entities
{
    public class Customer
    {
        public Customer( string name, string country)
        {
          
            Name = name;
            Country = country;
        }

      

        public string Name { get; set; }

        public string Country { get; set; }



      
    }




}
