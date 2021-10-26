using DataBaseAssigment.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataBaseAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calls the method 
            ListApartments();
        }
        static private void ListApartments()
        {

            //create a object of apartmentContext and call it db 
            using (ApartmentContext db = new ApartmentContext())
            {
                //Create a list of apartments(in databese) which is called apartmentList



                List<Apartment> apartmentList = db.Apartments
                    .Include(fd => fd.apartmentApplicants)
                    
                    .ThenInclude(b => b.Applicant)
                    
                    .ToList();

                //Create a foreach to loop trhough my list 
                foreach (var apartment in apartmentList)
                {

                    //creates en ampty variabel
                    string applicant = "";

                    //Create a new foreach to loop trhough my conected table(apartmentAplicant)
                    foreach (var apartmentApplicant in apartment.apartmentApplicants)
                    {
                        applicant += apartmentApplicant.Applicant.Name + " ";
                    }

                    //Prints database in the console
                    Console.WriteLine(applicant + " "+ apartment.Area +" " + apartment.Rent + " " + apartment.Rooms);
                }
            }
        }
    }
}


            
