using System;
using System.Collections.Generic;
using System.Text;

namespace BogusDemo.Domain.Models
{
    public class PersonRow
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public string Email { get; set; }

        public string City { get; set; }
        public DateTime DateOfBirth { get; set; }
     
       
    }
}
