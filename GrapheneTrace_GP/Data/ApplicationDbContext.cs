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
            // Seed Clinicians data


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


            // Seed Patients data

            modelBuilder.Entity<Patient>().HasData(

                new Patient
                {
                    Id = 1,
                    Title = "Mrs.",
                    FirstName = "Sophie",
                    LastName = "Night",
                    PatientId = 2693,
                    Status = "Active",
                    PatientAge = "40",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1984, 5, 21),
                    Email = "sophie.night@gmail.com",
                    Phone = "07012345678",
                    Address = "10 Downing Street",
                    City = "London",
                    PostCode = "SW1A 2AA"
                },

                new Patient
                {
                    Id = 2,
                    Title = "Ms.",
                    FirstName = "Janee",
                    LastName = "Harrison",
                    PatientId = 5987,
                    Status = "Active",
                    PatientAge = "32",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1992, 10, 11),
                    Email = "janee.harrison@gmail.com",
                    Phone = "07087654321",
                    Address = "20 Baker Street",
                    City = "London",
                    PostCode = "NW1 6XE"
                },

                new Patient
                {
                    Id = 3,
                    Title = "Mr",
                    FirstName = "Mike",
                    LastName = "Jackson",
                    PatientId = 8963,
                    Status = "Alert",
                    PatientAge = "29",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1995, 3, 3),
                    Email = "mike.jackson@gmail.com",
                    Phone = "07011223344",
                    Address = "30 Oxford Street",
                    City = "London",
                    PostCode = "W1D 1BS"
                },

                new Patient
                {
                    Id = 4,
                    Title = "Mr.",
                    FirstName = "Peter",
                    LastName = "Benjamin",
                    PatientId = 1257,
                    Status = "Active",
                    PatientAge = "49",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1978, 2, 15),
                    Email = "peter.benjamin@gmail.com",
                    Phone = "07098765432",
                    Address = "40 King Street",
                    City = "London",
                    PostCode = "W1F 0UT"
                },

                new Patient
                {
                    Id = 5,
                    Title = "Mrs.",
                    FirstName = "Hannah",
                    LastName = "Green",
                    PatientId = 9862,
                    Status = "Active",
                    PatientAge = "42",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1988, 4, 12),
                    Email = "Hannah.green@gmail.com",
                    Phone = "07012345678",
                    Address = "50 Queen Street",
                    City = "London",
                    PostCode = "W1A 1AA"
                },

                new Patient
                {
                    Id = 6,
                    Title = "Mr",
                    FirstName = "Andy",
                    LastName = "Bryan",
                    PatientId = 3654,
                    Status = "Not Active",
                    PatientAge = "38",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1986, 12, 22),
                    Email = "andy.bryan@gmail.com",
                    Phone = "07012345678",
                    Address = "60 King Street",
                    City = "London",
                    PostCode = "W1F 0UT"
                },

                new Patient
                {
                    Id = 7,
                    Title = "Mr",
                    FirstName = "Alex",
                    LastName = "White",
                    PatientId = 4527,
                    Status = "Active",
                    PatientAge = "38",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1986, 12, 22),
                    Email = "alex.white@gmail.com",
                    Phone = "07012345678",
                    Address = "70 King Street",
                    City = "London",
                    PostCode = "W1F 0UT"
                },


                new Patient
                {
                    Id = 8,
                    Title = "Mrs.",
                    FirstName = "Clara",
                    LastName = "Ashley",
                    PatientId = 6723,
                    Status = "Not Active",
                    PatientAge = "30",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1994, 3, 18),
                    Email = "clara.ashley@gmail.com",
                    Phone = "07012345678",
                    Address = "80 Queen Street",
                    City = "London",
                    PostCode = "W1A 1AA"
                },


                new Patient
                {
                    Id = 9,
                    Title = "Ms.",
                    FirstName = "Diana",
                    LastName = "Prince",
                    PatientId = 7894,
                    Status = "Not Active",
                    PatientAge = "34",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1990, 6, 4),
                    Email = "diana.prince@gmail.com",
                    Phone = "07012345678",
                    Address = "90 Queen Street",
                    City = "London",
                    PostCode = "W1A 1AA"
                },

                new Patient
                {
                    Id = 10,
                    Title = "Mr",
                    FirstName = "Richard",
                    LastName = "Watson",
                    PatientId = 3456,
                    Status = "Active",
                    PatientAge = "45",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1978, 2, 19),
                    Email = "richard.watson@gmail.com",
                    Phone = "07012345678",
                    Address = "100 Gotham Street",
                    City = "Gotham",
                    PostCode = "G1TH 0TH"
                },

                new Patient
                {
                    Id = 11,
                    Title = "Mr.",
                    FirstName = "James",
                    LastName = "Brown",
                    PatientId = 9123,
                    Status = "Not Active",
                    PatientAge = "28",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1995, 5, 15),
                    Email = "james.brown@gmail.com",
                    Phone = "07012345678",
                    Address = "110 Gotham Street",
                    City = "Gotham",
                    PostCode = "G1TH 0TH"
                },

                new Patient 
                {
                    Id = 12,
                    Title = "Ms",
                    FirstName = "Olivia",
                    LastName = "Patrick",
                    PatientId = 4569,
                    Status = "Active",
                    PatientAge = "39",
                    Gender = "Female",
                    DateOfBirth = new DateTime (1986, 12, 08),
                    Email = "Olivia12.Patrick@gmail.com",
                    Phone = "07452136925",
                    Address = "20 Avenue Glass Rd",
                    City = "Bristol",
                    PostCode = "B17G BYR"
                },

                new Patient
                {
                    Id = 13,
                    Title = "Mr.",
                    FirstName = "Liam",
                    LastName = "Smith",
                    PatientId = 7891,
                    Status = "Active",
                    PatientAge = "35",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1988, 3, 22),
                    Email = "liam.smith@gmail.com",
                    Phone = "07345678912",
                    Address = "30 River Side",
                    City = "Manchester",
                    PostCode = "M1 2AB"
                },

                new Patient
                {
                    Id = 14,
                    Title = "Mrs.",
                    FirstName = "Ava",
                    LastName = "Johnson",
                    PatientId = 2345,
                    Status = "Not Active",
                    PatientAge = "41",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1982, 7, 30),
                    Email = "ava.johnson@gmail.com",
                    Phone = "07345678912",
                    Address = "40 River Side",
                    City = "Manchester",
                    PostCode = "M1 2AB"
                },

                new Patient
                {
                    Id = 15,
                    Title = "Ms.",
                    FirstName = "Isabella",
                    LastName = "Williams",
                    PatientId = 6789,
                    Status = "Active",
                    PatientAge = "29",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1994, 4, 12),
                    Email = "isabella.williams@gmail.com",
                    Phone = "07412345678",
                    Address = "50 River Side",
                    City = "Manchester",
                    PostCode = "M1 2AB"
                },

                new Patient
                {
                    Id = 16,
                    Title = "Mr.",
                    FirstName = "Noah",
                    LastName = "Brown",
                    PatientId = 3457,
                    Status = "Active",
                    PatientAge = "33",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    Email = "noah.brown@gmail.com",
                    Phone = "07512345678",
                    Address = "60 River Side",
                    City = "Manchester",
                    PostCode = "M1 2AB"
                }

            );

        }

    }

}


