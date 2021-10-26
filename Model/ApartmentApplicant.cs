using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseAssigment.Model
{
    public class ApartmentApplicant
    {
        //public int Id { get; set; }

        public int ApartmentId { get; set; }

        public int ApplicantId { get; set; }


        //navigation property to help us code 
        public Applicant Applicant { get; set; }
        public Apartment Apartment { get; set; }
    }
}


        

