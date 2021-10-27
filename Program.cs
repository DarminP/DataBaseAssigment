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
            //First prints out list of applicants in the console
            Console.WriteLine("press a key to see list of applicants");
            Console.ReadKey();
            listApplicants();

            //asks if you want to add new applicant
            Console.WriteLine("press a key to add new applcant");
            Console.ReadKey();

            //asks to enter data and read it 
            Console.WriteLine(" Enter the Applicant name ");
            string aplicantName = Console.ReadLine();
            Console.WriteLine(" Enter the Applicant age ");
            int aplicantAge = Convert.ToInt32(Console.ReadLine());


            //First calls method which create new applicant and than calls method to print udated list of applicants
            CreateApplicant(aplicantName, aplicantAge);
            Console.WriteLine("new applicant added to list! ");
            listApplicants();


            //Calls the method to list apartments and applicants 
            Console.WriteLine("Press a key to see apartments and applicants ");
            Console.ReadKey();
            ListApartments();
           

        }

        #region Read (CRUD SYSTEM)
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
        #endregion

        #region Read List of applicants
        //read applicants 
        static private void listApplicants()
        {
            using (ApartmentContext db = new ApartmentContext())
            {
                List<Applicant> applicanList = db.Applicants.ToList();

                foreach (var applicantN in applicanList)
                {
                    string newapplicant = applicantN.Name +  " " + applicantN.Age;

                    Console.WriteLine(newapplicant);

                }           
            }
        }
        #endregion

        #region Create new applicant (CRUD SYSTEM)
        static void CreateApplicant(string applicantName, int age)
        {
            using (ApartmentContext db = new ApartmentContext())
            {

                Applicant newAplicant = new Applicant();

                newAplicant.Name = applicantName;
                newAplicant.Age = age;

                db.Applicants.Add(newAplicant);
                db.SaveChanges();
            }
        } 
        #endregion
    }

}
             

            

               

                    







            
