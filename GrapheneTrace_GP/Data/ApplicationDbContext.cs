using Microsoft.EntityFrameworkCore;
using GrapheneTrace_GP.Areas.Admin.Models;

namespace GrapheneTrace_GP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Clinicians> Clinicians { get; set; }
        public DbSet<Patient> Patients { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Clinicians>().HasData(
                new Clinicians
                {
                    Id = 1,
                    Title = "Dr.",
                    ClinicianFirstName = "John",
                    ClinicianLastName = "Michael",
                    ClinicianId = 852693,
                    ClinicianSpeciality = "Cardiologist",
                    ClinicianAge = "40",
                    Email = "john.michael@example.com",
                    Gender= "Male",
                    DateOfBirth = new DateTime(1984, 1, 12),
                    Phone = "07111111111",
                    Address = "1 Main Street",
                    City = "London",
                    PostCode = "A1 1AA",
                    Status = "Active"
                },

                new Clinicians
                {
                    Id = 2,
                    Title = "Dr.",
                    ClinicianFirstName = "Sarah",
                    ClinicianLastName = "Peterson",
                    ClinicianId = 698235,
                    ClinicianSpeciality = "Neurology",
                    ClinicianAge = "32",
                    Email = "sarah.peterson@hospital.com",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1992, 7, 5),
                    Phone = "07222222222",
                    Address = "2 Main Street",
                    City = "London",
                    PostCode = "A2 2BB",
                    Status = "Active"
                },

                new Clinicians
                {
                    Id = 3,
                    Title = "Dr.",
                    ClinicianFirstName = "Emily",
                    ClinicianLastName = "Johnson",
                    ClinicianId = 456973,
                    ClinicianSpeciality = "Pediatrics",
                    ClinicianAge = "30",
                    Email = "emily.johnson@hospital.com",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1994, 9, 8),
                    Phone = "07333333333",
                    Address = "3 Main Street",
                    City = "London",
                    PostCode = "A3 3CC",
                    Status = "Active"
                },

                new Clinicians
                {
                    Id = 4,
                    Title = "Dr.",
                    ClinicianFirstName = "David",
                    ClinicianLastName = "Anderson",
                    ClinicianId = 325698,
                    ClinicianSpeciality = "Neurologist",
                    ClinicianAge = "29",
                    Email = "david.anderson@hospital.com",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1995, 4, 18),
                    Phone = "07444444444",
                    Address = "4 Main Street",
                    City = "London",
                    PostCode = "A4 4DD",
                    Status = "Active"
                },

                new Clinicians
                {
                    Id = 5,
                    Title = "Dr.",
                    ClinicianFirstName = "Emmanuel",
                    ClinicianLastName = "State",
                    ClinicianId = 258963,
                    ClinicianSpeciality = "Surgeon",
                    ClinicianAge = "49",
                    Email = "emmanuel.state@hospital.com",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1975, 3, 15),
                    Phone = "07555555555",
                    Address = "5 Main Street",
                    City = "London",
                    PostCode = "A5 5EE",
                    Status = "Active"
                },

                new Clinicians
                {
                    Id = 6,
                    Title = "Dr.",
                    ClinicianFirstName = "Mike",
                    ClinicianLastName = "Stephen",
                    ClinicianId = 258694,
                    ClinicianSpeciality = "Radiologist",
                    ClinicianAge = "42",
                    Email = "mike.stephen@hospital.com",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1982, 11, 22),
                    Phone = "07666666666",
                    Address = "6 Main Street",
                    City = "London",
                    PostCode = "A6 6FF",
                    Status = "Active"
                },

                new Clinicians
                {
                    Id = 7,
                    Title = "Dr.",
                    ClinicianFirstName = "Noah",
                    ClinicianLastName = "Hyper",
                    ClinicianId = 784561,
                    ClinicianSpeciality = "Psychiatrist",
                    ClinicianAge = "38",
                    Email = "noah.hyper@hospital.com",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1986, 6, 10),
                    Phone = "07777777777",
                    Address = "7 Main Street",
                    City = "London",
                    PostCode = "A7 7GG",
                    Status = "Active"
                },

                new Clinicians
                {
                    Id = 8,
                    Title = "Dr.",
                    ClinicianFirstName = "Helen",
                    ClinicianLastName = "Cooke",
                    ClinicianId = 125489,
                    ClinicianSpeciality = "Gynaecologist",
                    ClinicianAge = "38",
                    Email = "helen.cooke@hospital.com",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1986, 2, 4),
                    Phone = "07888888888",
                    Address = "8 Main Street",
                    City = "London",
                    PostCode = "A8 8HH",
                    Status = "Active"
                },

                new Clinicians
                {
                    Id = 9,
                    Title = "Dr.",
                    ClinicianFirstName = "Rose",
                    ClinicianLastName = "Night",
                    ClinicianId = 508342,
                    ClinicianSpeciality = "Surgeon",
                    ClinicianAge = "42",
                    Email = "rose.night@hospital.com",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1982, 9, 9),
                    Phone = "07999999999",
                    Address = "9 Main Street",
                    City = "London",
                    PostCode = "A9 9JJ",
                    Status = "Active"
                },

                new Clinicians
                {
                    Id = 10,
                    Title = "Dr.",
                    ClinicianFirstName = "Jake",
                    ClinicianLastName = "Watson",
                    ClinicianId = 159753,
                    ClinicianSpeciality = "Orthopaedic",
                    ClinicianAge = "54",
                    Email = "jake.watson@hospital.com",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1970, 1, 1),
                    Phone = "07010101010",
                    Address = "10 Main Street",
                    City = "London",
                    PostCode = "B1 1AA",
                    Status = "Active"
                },

                new Clinicians
                {
                    Id = 11,
                    Title = "Dr.",
                    ClinicianFirstName = "Emma",
                    ClinicianLastName = "Richard",
                    ClinicianId = 753561,
                    ClinicianSpeciality = "Dermatologist",
                    ClinicianAge = "34",
                    Email = "emma.richard@hospital.com",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1990, 8, 14),
                    Phone = "07020202020",
                    Address = "11 Main Street",
                    City = "London",
                    PostCode = "B2 2BB",
                    Status = "Active"
                }

            );
        }

    }

}


