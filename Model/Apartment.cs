using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBaseAssigment.Model
{
    public class Apartment
    {
        public int Id { get; set; }
        [Required]
        public string Area { get; set; }

        public int Rent { get; set; }

        public int LandlordId { get; set; }
        public Landlord Landlord { get; set; }
    }
}
        

