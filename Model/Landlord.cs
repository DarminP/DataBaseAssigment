using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBaseAssigment.Model
{
    public class Landlord
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
