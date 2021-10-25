using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseAssigment.Model
{
    class ApartmentContext : DbContext 
    {
        public DbSet<Apartment> Apartments { get; set; }

        public DbSet<Landlord> Landlords { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-VAD6TT8;Database=ApartmentDB;Trusted_Connection=True;");
        }
    }
    

}
