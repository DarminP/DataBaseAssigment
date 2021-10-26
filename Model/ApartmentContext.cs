using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseAssigment.Model
{
    class ApartmentContext : DbContext 
    {
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<ApartmentApplicant> ApartmentApplicants  { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-VAD6TT8;Database=ApartmentDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //telling the entety to create primary key for apartmentApplicant
            modelBuilder.Entity<ApartmentApplicant>()
                .HasKey(k => new { k.ApartmentId, k.ApplicantId });

            //create many to many relation between applicant and apartmentAplicant
            modelBuilder.Entity<ApartmentApplicant>()
                .HasOne(b => b.Applicant)
                .WithMany(bc => bc.apartmentApplicants)
                .HasForeignKey(d => d.ApplicantId);

            //create many to many relation between apartment and apartmentAplicant
            modelBuilder.Entity<ApartmentApplicant>()
                .HasOne(b => b.Apartment)
                .WithMany(bc => bc.apartmentApplicants)
                .HasForeignKey(k => k.ApartmentId);
        }
    }
    

}
