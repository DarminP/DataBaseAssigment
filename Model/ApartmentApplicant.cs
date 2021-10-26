using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseAssigment.Model
{
    public class ApartmentApplicant
    {
        public int Id { get; set; }

        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }

        public int ApplicantId { get; set; }
        public Applicant Applicant { get; set; }

    }
}
