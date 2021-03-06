using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBaseAssigment.Model
{
    public class Applicant
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }

        public List<ApartmentApplicant> apartmentApplicants { get; set; }
    }
}
