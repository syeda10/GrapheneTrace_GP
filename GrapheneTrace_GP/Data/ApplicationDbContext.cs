using GrapheneTrace_GP.Areas.Admin.Models;
using GrapheneTrace_GP.Areas.Admin.Models.ClinicianAddProfile;
using GrapheneTrace_GP.Areas.Admin.Models.PatientAddProfile;
using GrapheneTrace_GP.Areas.Admin.ViewModels;
using GrapheneTrace_GP.Models;
using Microsoft.EntityFrameworkCore;

namespace GrapheneTrace_GP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        
        }
        
        //Clinician page
        public DbSet<Clinicians> Clinicians { get; set; }

        //Patient Page
        public DbSet<Patient> Patients { get; set; }
        
        //Patient Appointments
        public DbSet<Appointment> Appointments { get; set; }

        //Clinician Alerts
        public DbSet<ClinicianAlert> ClinicianAlerts { get; set; }

        //Alert page
        public DbSet<Alert> Alerts { get; set; }

        //Clinician Add profile
        public DbSet<ClinicianProfile> ClinicianProfile { get; set; }
        public DbSet<ClinicianProfessionalInfo> ClinicianProfessionalInfo { get; set; }
        public DbSet<ClinicianAssignments> ClinicianAssignments { get; set; }
        public DbSet<ClinicianVerification> ClinicianVerification { get; set; }

        //Patients Add Profile
        public DbSet<PatientProfile> PatientProfile { get; set; }
        public DbSet<PatientMedicalInfo> PatientMedicalInfos { get; set; }
        public DbSet<PatientAssignments> PatientAssignments { get; set; }
        public DbSet<PatientVerification> PatientVerifications { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Clinicians data

            modelBuilder.Entity<ClinicianAlert>()
           .HasOne(a => a.Clinician)
            .WithMany(c => c.Alerts)
            .HasForeignKey(a => a.ClinicianId)
            .OnDelete(DeleteBehavior.Cascade);

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
                    Gender = "Male",
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

            //Alerts data for clinicians

            // Clinician Alerts Seed Data
            modelBuilder.Entity<ClinicianAlert>().HasData(

                // ------- Dr. John Michael (ID = 1) -------
                new ClinicianAlert { AlertId = 1, ClinicianId = 1, AlertType = "Certification updated", AlertDateTime = new DateTime(2025, 02, 11, 13, 15, 00) },
                new ClinicianAlert { AlertId = 2, ClinicianId = 1, AlertType = "Profile updated", AlertDateTime = new DateTime(2025, 02, 11, 10, 12, 00) },
                new ClinicianAlert { AlertId = 3, ClinicianId = 1, AlertType = "New patient assigned", AlertDateTime = new DateTime(2025, 02, 11, 09, 00, 00) },

                // ------- Dr. Sarah Peterson (ID = 2) -------
                new ClinicianAlert { AlertId = 4, ClinicianId = 2, AlertType = "Status active", AlertDateTime = new DateTime(2025, 02, 11, 08, 00, 00) },
                new ClinicianAlert { AlertId = 5, ClinicianId = 2, AlertType = "Status inactive", AlertDateTime = new DateTime(2025, 02, 11, 18, 30, 00) },
                new ClinicianAlert { AlertId = 6, ClinicianId = 2, AlertType = "High workload", AlertDateTime = new DateTime(2025, 02, 10, 13, 30, 00) },
                new ClinicianAlert { AlertId = 7, ClinicianId = 2, AlertType = "Certification expired", AlertDateTime = new DateTime(2025, 02, 11, 12, 00, 00) },

                // ------- Dr. Emily Johnson (ID = 3) -------
                new ClinicianAlert { AlertId = 8, ClinicianId = 3, AlertType = "Shift change request", AlertDateTime = new DateTime(2025, 02, 09, 10, 00, 00) },
                new ClinicianAlert { AlertId = 9, ClinicianId = 3, AlertType = "Status active", AlertDateTime = new DateTime(2025, 02, 09, 09, 30, 00) },

                // ------- Dr. David Anderson (ID = 4) -------
                new ClinicianAlert { AlertId = 10, ClinicianId = 4, AlertType = "Documents uploaded", AlertDateTime = new DateTime(2025, 02, 08, 17, 40, 00) },
                new ClinicianAlert { AlertId = 11, ClinicianId = 4, AlertType = "Verification pending", AlertDateTime = new DateTime(2025, 02, 08, 13, 30, 00) },

                // ------- Dr. Emmanuel State (ID = 5) -------
                new ClinicianAlert { AlertId = 12, ClinicianId = 5, AlertType = "New patient assigned", AlertDateTime = new DateTime(2025, 02, 07, 14, 25, 00) },
                new ClinicianAlert { AlertId = 13, ClinicianId = 5, AlertType = "Status inactive", AlertDateTime = new DateTime(2025, 02, 07, 09, 50, 00) },

                // ------- Dr. Mike Stephen (ID = 6) -------
                new ClinicianAlert { AlertId = 14, ClinicianId = 6, AlertType = "Shift schedule updated", AlertDateTime = new DateTime(2025, 02, 06, 11, 10, 00) },

                // ------- Dr. Noah Hyper (ID = 7) -------
                new ClinicianAlert { AlertId = 15, ClinicianId = 7, AlertType = "High workload", AlertDateTime = new DateTime(2025, 02, 05, 16, 45, 00) },
                new ClinicianAlert { AlertId = 16, ClinicianId = 7, AlertType = "Profile updated", AlertDateTime = new DateTime(2025, 02, 04, 10, 20, 00) },

                // ------- Dr. Helen Cooke (ID = 8) -------
                new ClinicianAlert { AlertId = 17, ClinicianId = 8, AlertType = "New patient assigned", AlertDateTime = new DateTime(2025, 02, 03, 14, 20, 00) },
                new ClinicianAlert { AlertId = 18, ClinicianId = 8, AlertType = "Certification updated", AlertDateTime = new DateTime(2025, 02, 03, 08, 40, 00) },

                // ------- Dr. Rose Night (ID = 9) -------
                new ClinicianAlert { AlertId = 19, ClinicianId = 9, AlertType = "Emergency override assigned", AlertDateTime = new DateTime(2025, 02, 02, 17, 00, 00) },

                // ------- Dr. Jake Watson (ID = 10) -------
                new ClinicianAlert { AlertId = 20, ClinicianId = 10, AlertType = "New patient assigned", AlertDateTime = new DateTime(2025, 02, 01, 09, 10, 00) },

                // ------- Dr. Emma Richard (ID = 11) -------
                new ClinicianAlert { AlertId = 21, ClinicianId = 11, AlertType = "Certification expired", AlertDateTime = new DateTime(2025, 01, 29, 15, 35, 00) },
                new ClinicianAlert { AlertId = 22, ClinicianId = 11, AlertType = "Shift change request", AlertDateTime = new DateTime(2025, 01, 29, 10, 00, 00) }
            );



            // Seed Patients data
            modelBuilder.Entity<Patient>()
            .HasOne(p => p.Clinician)
            .WithMany(c => c.Patients)
            .HasForeignKey(p => p.ClinicianId)
             .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Patient>().HasData(

                new Patient
                {
                    PatientId = 2693,
                    Title = "Mrs.",
                    FirstName = "Sophie",
                    LastName = "Night",
                    ClinicianId = 2,
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
                    PatientId = 5987,
                    Title = "Ms.",
                    FirstName = "Janee",
                    LastName = "Harrison",
                    ClinicianId = 4,
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

                    PatientId = 8963,
                    Title = "Mr",
                    FirstName = "Mike",
                    LastName = "Jackson",
                    ClinicianId = 1,
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
                    PatientId = 1257,
                    Title = "Mr.",
                    FirstName = "Peter",
                    LastName = "Benjamin",
                    ClinicianId = 5,
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
                    PatientId = 9862,
                    Title = "Mrs.",
                    FirstName = "Hannah",
                    LastName = "Green",
                    ClinicianId = 1,
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
                    PatientId = 3654,
                    Title = "Mr",
                    FirstName = "Andy",
                    LastName = "Bryan",
                    ClinicianId = 5,
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
                    PatientId = 4527,
                    Title = "Mr",
                    FirstName = "Alex",
                    LastName = "White",
                    ClinicianId = 4,
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
                    PatientId = 6723,
                    Title = "Mrs.",
                    FirstName = "Clara",
                    LastName = "Ashley",
                    ClinicianId = 2,
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
                    PatientId = 7894,
                    Title = "Ms.",
                    FirstName = "Diana",
                    LastName = "Prince",
                    ClinicianId = 7,
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
                    PatientId = 3456,
                    Title = "Mr",
                    FirstName = "Richard",
                    LastName = "Watson",
                    ClinicianId = 8,
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
                    PatientId = 9123,
                    Title = "Mr.",
                    FirstName = "James",
                    LastName = "Brown",
                    ClinicianId = 8,
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
                    PatientId = 4569,
                    Title = "Ms",
                    FirstName = "Olivia",
                    LastName = "Patrick",
                    ClinicianId = 1,
                    Status = "Active",
                    PatientAge = "39",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1986, 12, 08),
                    Email = "Olivia12.Patrick@gmail.com",
                    Phone = "07452136925",
                    Address = "20 Avenue Glass Rd",
                    City = "Bristol",
                    PostCode = "B17G BYR"
                },

                new Patient
                {
                    PatientId = 7891,
                    Title = "Mr.",
                    FirstName = "Liam",
                    LastName = "Smith",
                    ClinicianId = 3,
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
                    PatientId = 2345,
                    Title = "Mrs.",
                    FirstName = "Ava",
                    LastName = "Johnson",
                    ClinicianId = 6,
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
                    PatientId = 6789,
                    Title = "Ms.",
                    FirstName = "Isabella",
                    LastName = "Williams",
                    ClinicianId = 7,
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
                    PatientId = 3457,
                    Title = "Mr.",
                    FirstName = "Noah",
                    LastName = "Brown",
                    ClinicianId = 6,
                    Status = "Active",
                    PatientAge = "33",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    Email = "noah.brown@gmail.com",
                    Phone = "07512345678",
                    Address = "60 River Side",
                    City = "Manchester",
                    PostCode = "M1 2AB"
                },



                 new Patient
                 {
                     PatientId = 8123,
                     Title = "Mr.",
                     FirstName = "Harvey",
                     LastName = "Cole",
                     ClinicianId = 2,
                     Status = "Active",
                     PatientAge = "37",
                     Gender = "Male",
                     DateOfBirth = new DateTime(1987, 4, 10),
                     Email = "harvey.cole@gmail.com",
                     Phone = "07581234567",
                     Address = "12 Wood Street",
                     City = "London",
                     PostCode = "E2 4AA"
                 },


                new Patient
                {
                    PatientId = 8125,
                    Title = "Ms.",
                    FirstName = "Layla",
                    LastName = "Stevens",
                    ClinicianId = 3,
                    Status = "Active",
                    PatientAge = "44",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1980, 7, 12),
                    Email = "layla.stevens@gmail.com",
                    Phone = "07411122233",
                    Address = "28 Crescent Lane",
                    City = "Manchester",
                    PostCode = "M3 4GH"
                },

                new Patient
                {
                    PatientId = 8126,
                    Title = "Mr.",
                    FirstName = "Brandon",
                    LastName = "Lee",
                    ClinicianId = 3,
                    Status = "Not Active",
                    PatientAge = "52",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1972, 8, 20),
                    Email = "brandon.lee@gmail.com",
                    Phone = "07422233344",
                    Address = "4 Mill View",
                    City = "Manchester",
                    PostCode = "M4 1AB"
                },

                new Patient
                {
                    PatientId = 8127,
                    Title = "Mr.",
                    FirstName = "Tom",
                    LastName = "Barker",
                    ClinicianId = 4,
                    Status = "Active",
                    PatientAge = "26",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1998, 11, 5),
                    Email = "tom.barker@gmail.com",
                    Phone = "07399988877",
                    Address = "7 Elm Park",
                    City = "London",
                    PostCode = "SW1 7DF"
                },

                new Patient
                {
                    PatientId = 8128,
                    Title = "Mrs.",
                    FirstName = "Nora",
                    LastName = "Hughes",
                    ClinicianId = 4,
                    Status = "Active",
                    PatientAge = "48",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1976, 5, 30),
                    Email = "nora.hughes@gmail.com",
                    Phone = "07311155522",
                    Address = "22 Green Lane",
                    City = "London",
                    PostCode = "SW1 9GH"
                },

                 new Patient
                 {
                     PatientId = 8129,
                     Title = "Mr.",
                     FirstName = "Ethan",
                     LastName = "Morris",
                     ClinicianId = 1,
                     Status = "Active",
                     PatientAge = "31",
                     Gender = "Male",
                     DateOfBirth = new DateTime(1993, 1, 19),
                     Email = "ethan.morris@gmail.com",
                     Phone = "07812345670",
                     Address = "18 Maple Street",
                     City = "Bristol",
                     PostCode = "BS1 3DA"
                 },

                new Patient
                {
                    PatientId = 8130,
                    Title = "Ms.",
                    FirstName = "Chloe",
                    LastName = "Adams",
                    ClinicianId = 1,
                    Status = "Not Active",
                    PatientAge = "36",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1988, 9, 14),
                    Email = "chloe.adams@gmail.com",
                    Phone = "07898732100",
                    Address = "45 River Way",
                    City = "Bristol",
                    PostCode = "BS2 5HB"
                },

                new Patient
                {
                    PatientId = 8131,
                    Title = "Mr.",
                    FirstName = "Kyle",
                    LastName = "Garcia",
                    ClinicianId = 5,
                    Status = "Active",
                    PatientAge = "40",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1984, 12, 1),
                    Email = "kyle.garcia@gmail.com",
                    Phone = "07788822211",
                    Address = "33 Oak Road",
                    City = "London",
                    PostCode = "NW1 5RT"
                },

                new Patient
                {
                    PatientId = 8132,
                    Title = "Ms.",
                    FirstName = "Amelia",
                    LastName = "Scott",
                    ClinicianId = 5,
                    Status = "Active",
                    PatientAge = "24",
                    Gender = "Female",
                    DateOfBirth = new DateTime(2000, 4, 9),
                    Email = "amelia.scott@gmail.com",
                    Phone = "07722288899",
                    Address = "91 Hill Street",
                    City = "London",
                    PostCode = "NW3 8YZ"
                },

                new Patient
                {
                    PatientId = 8133,
                    Title = "Mr.",
                    FirstName = "Jacob",
                    LastName = "Shaw",
                    ClinicianId = 6,
                    Status = "Active",
                    PatientAge = "33",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1991, 2, 11),
                    Email = "jacob.shaw@gmail.com",
                    Phone = "07655533322",
                    Address = "4 Silver Street",
                    City = "Manchester",
                    PostCode = "M2 7EG"
                },

                new Patient
                {
                    PatientId = 8134,
                    Title = "Mrs.",
                    FirstName = "Grace",
                    LastName = "Miller",
                    ClinicianId = 6,
                    Status = "Active",
                    PatientAge = "46",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1978, 1, 25),
                    Email = "grace.miller@gmail.com",
                    Phone = "07611122244",
                    Address = "20 Brook Lane",
                    City = "Manchester",
                    PostCode = "M2 9GT"
                },

                new Patient
                {
                    PatientId = 8135,
                    Title = "Mr.",
                    FirstName = "Ryan",
                    LastName = "Evans",
                    ClinicianId = 7,
                    Status = "Not Active",
                    PatientAge = "39",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1985, 6, 6),
                    Email = "ryan.evans@gmail.com",
                    Phone = "07544455566",
                    Address = "14 Sunset Drive",
                    City = "Liverpool",
                    PostCode = "L1 2AA"
                },

                new Patient
                {
                    PatientId = 8136,
                    Title = "Ms.",
                    FirstName = "Sophia",
                    LastName = "Clarke",
                    ClinicianId = 7,
                    Status = "Active",
                    PatientAge = "27",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1997, 11, 3),
                    Email = "sophia.clarke@gmail.com",
                    Phone = "07555566677",
                    Address = "22 Hilltop Road",
                    City = "Liverpool",
                    PostCode = "L2 1BB"
                },

                new Patient
                {
                    PatientId = 8137,
                    Title = "Mrs.",
                    FirstName = "Ella",
                    LastName = "Turner",
                    ClinicianId = 8,
                    Status = "Active",
                    PatientAge = "50",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1974, 3, 30),
                    Email = "ella.turner@gmail.com",
                    Phone = "07477788822",
                    Address = "10 Riverbank",
                    City = "Gotham",
                    PostCode = "G1TH 2TT"
                },

                new Patient
                {
                    PatientId = 8138,
                    Title = "Mr.",
                    FirstName = "Nathan",
                    LastName = "Brooks",
                    ClinicianId = 8,
                    Status = "Active",
                    PatientAge = "41",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1983, 5, 8),
                    Email = "nathan.brooks@gmail.com",
                    Phone = "07422244455",
                    Address = "18 Lantern Lane",
                    City = "Gotham",
                    PostCode = "G1TH 3PP"
                },

                new Patient
                {
                    PatientId = 8139,
                    Title = "Mr.",
                    FirstName = "Leo",
                    LastName = "Robinson",
                    ClinicianId = 2,
                    Status = "Active",
                    PatientAge = "34",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1990, 5, 28),
                    Email = "leo.robinson@gmail.com",
                    Phone = "07522113344",
                    Address = "6 Forest Road",
                    City = "London",
                    PostCode = "E1 7HH"
                },

                new Patient
                {
                    PatientId = 8140,
                    Title = "Ms.",
                    FirstName = "Holly",
                    LastName = "Grant",
                    ClinicianId = 5,
                    Status = "Not Active",
                    PatientAge = "31",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1993, 12, 13),
                    Email = "holly.grant@gmail.com",
                    Phone = "07512398765",
                    Address = "8 Oakwood",
                    City = "London",
                    PostCode = "NW8 1GG"
                },

                new Patient
                {
                    PatientId = 8141,
                    Title = "Mr.",
                    FirstName = "Aaron",
                    LastName = "Foster",
                    ClinicianId = 3,
                    Status = "Active",
                    PatientAge = "47",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1977, 7, 17),
                    Email = "aaron.foster@gmail.com",
                    Phone = "07489012345",
                    Address = "39 Slope View",
                    City = "Manchester",
                    PostCode = "M4 9QA"
                }


            );

            //Appointment Seeding


            //Alerts

            modelBuilder.Entity<Alert>().HasData(
                  // -------------------- SYSTEM ALERTS ----------------------
                  new Alert
                  {
                      Id = 1,
                      AlertCode = "ALT-01",
                      Type = "System",
                      Message = "System software update available - pending installation approval",
                      Priority = "Medium",
                      Status = "Read",
                      RelatedId = null,
                      CreatedAt = new DateTime(2025, 02, 01, 10, 00, 00)
                  },
                  new Alert
                  {
                      Id = 2,
                      AlertCode = "ALT-02",
                      Type = "System",
                      Message = "Profile verification pending for Dr Anderson",
                      Priority = "High",
                      Status = "Unread",
                      RelatedId = "325698",
                      CreatedAt = new DateTime(2025, 02, 01, 11, 20, 00)
                  },
                  new Alert
                  {
                      Id = 3,
                      AlertCode = "ALT-03",
                      Type = "System",
                      Message = "Data backup completed successfully",
                      Priority = "Low",
                      Status = "Read",
                      RelatedId = null,
                      CreatedAt = new DateTime(2025, 02, 02, 08, 10, 00)
                  },

                  // ------------------ CLINICIAN ALERTS ----------------------
                  new Alert
                  {
                      Id = 4,
                      AlertCode = "ALT-10",
                      Type = "Clinician",
                      Message = "New patient assigned to Dr John Michael: Olivia Patrick",
                      Priority = "Low",
                      Status = "Read",
                      RelatedId = "4569",
                      CreatedAt = new DateTime(2025, 02, 10, 09, 00, 00)
                  },
                  new Alert
                  {
                      Id = 5,
                      AlertCode = "ALT-11",
                      Type = "Clinician",
                      Message = "Workload limit reached for Dr Sarah Peterson",
                      Priority = "High",
                      Status = "Unread",
                      RelatedId = "698235",
                      CreatedAt = new DateTime(2025, 02, 10, 12, 30, 00)
                  },
                  new Alert
                  {
                      Id = 6,
                      AlertCode = "ALT-12",
                      Type = "Clinician",
                      Message = "Certification updated for Dr Emily Johnson",
                      Priority = "Medium",
                      Status = "Read",
                      RelatedId = "456973",
                      CreatedAt = new DateTime(2025, 02, 11, 13, 15, 00)
                  },
                  new Alert
                  {
                      Id = 7,
                      AlertCode = "ALT-13",
                      Type = "Clinician",
                      Message = "Shift change request approved for Dr David Anderson",
                      Priority = "Low",
                      Status = "Read",
                      RelatedId = "325698",
                      CreatedAt = new DateTime(2025, 02, 11, 10, 12, 00)
                  },
                  new Alert
                  {
                      Id = 8,
                      AlertCode = "ALT-14",
                      Type = "Clinician",
                      Message = "Dr Emmanuel State reached maximum patient load",
                      Priority = "High",
                      Status = "Unread",
                      RelatedId = "258963",
                      CreatedAt = new DateTime(2025, 02, 11, 16, 45, 00)
                  },

                  // -------------------- PATIENT ALERTS ----------------------
                  new Alert
                  {
                      Id = 9,
                      AlertCode = "ALT-20",
                      Type = "Patient",
                      Message = "ECG anomaly detected for patient Jacob Flynn – immediate review recommended",
                      Priority = "Critical",
                      Status = "Unread",
                      RelatedId = "9862",
                      CreatedAt = new DateTime(2025, 02, 12, 02, 35, 00)
                  },
                  new Alert
                  {
                      Id = 10,
                      AlertCode = "ALT-21",
                      Type = "Patient",
                      Message = "Medication conflict detected for patient Alex White (penicillin allergy)",
                      Priority = "High",
                      Status = "Unread",
                      RelatedId = "4527",
                      CreatedAt = new DateTime(2025, 02, 12, 09, 00, 00)
                  },
                  new Alert
                  {
                      Id = 11,
                      AlertCode = "ALT-22",
                      Type = "Patient",
                      Message = "Follow-up required for patient Hannah Green – symptoms recorded",
                      Priority = "Medium",
                      Status = "Unread",
                      RelatedId = "9862",
                      CreatedAt = new DateTime(2025, 02, 13, 11, 45, 00)
                  },
                  new Alert
                  {
                      Id = 12,
                      AlertCode = "ALT-23",
                      Type = "Patient",
                      Message = "Routine blood pressure check due for patient Clara Ashley",
                      Priority = "Low",
                      Status = "Read",
                      RelatedId = "6723",
                      CreatedAt = new DateTime(2025, 02, 14, 10, 00, 00)
                  },
                  new Alert
                  {
                      Id = 13,
                      AlertCode = "ALT-24",
                      Type = "Patient",
                      Message = "Patient Liam Smith reported recurrent chest discomfort",
                      Priority = "High",
                      Status = "Unread",
                      RelatedId = "7891",
                      CreatedAt = new DateTime(2025, 02, 14, 14, 30, 00)
                  },

                  // ------------------ MORE SYSTEM ALERTS --------------------
                  new Alert
                  {
                      Id = 14,
                      AlertCode = "ALT-30",
                      Type = "System",
                      Message = "11:00 PM Dashboard will be temporarily unavailable due to maintenance",
                      Priority = "Low",
                      Status = "Read",
                      RelatedId = null,
                      CreatedAt = new DateTime(2025, 02, 15, 23, 00, 00)
                  },
                  new Alert
                  {
                      Id = 15,
                      AlertCode = "ALT-31",
                      Type = "System",
                      Message = "Security scan completed — No threats detected",
                      Priority = "Low",
                      Status = "Read",
                      RelatedId = null,
                      CreatedAt = new DateTime(2025, 02, 15, 18, 15, 00)
                  },

                    new Alert
                    {
                        Id = 16,
                        AlertCode = "ALT-32",
                        Type = "System",
                        Message = "New feature rollout: Enhanced reporting tools now available",
                        Priority = "Medium",
                        Status = "Read",
                        RelatedId = null,
                        CreatedAt = new DateTime(2025, 02, 16, 09, 30, 00)
                    },

                    new Alert
                    {
                        Id = 17,
                        AlertCode = "ALT-33",
                        Type = "System",
                        Message = "User activity logs archived successfully",
                        Priority = "Low",
                        Status = "Read",
                        RelatedId = null,
                        CreatedAt = new DateTime(2025, 02, 16, 14, 45, 00)
                    },

                    new Alert
                    {
                        Id = 18,
                        AlertCode = "ALT-34",
                        Type = "System",
                        Message = "Critical vulnerability patch applied to server infrastructure",
                        Priority = "Critical",
                        Status = "Unread",
                        RelatedId = null,
                        CreatedAt = new DateTime(2025, 02, 17, 03, 20, 00)
                    },

                    new Alert
                    {
                        Id = 19,
                        AlertCode = "ALT-35",
                        Type = "System",
                        Message = "Monthly system performance report is now available",
                        Priority = "Medium",
                        Status = "Read",
                        RelatedId = null,
                        CreatedAt = new DateTime(2025, 02, 17, 12, 00, 00)
                    }
            );



            // Add Profile Clinician


            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClinicianProfile>()
                .HasOne(c => c.ProfessionalInfo)
                .WithOne(pi => pi.Clinician)
                .HasForeignKey<ClinicianProfessionalInfo>(pi => pi.ClinicianId);

            modelBuilder.Entity<ClinicianProfile>()
                .HasOne(c => c.Assignments)
                .WithOne(a => a.Clinician)
                .HasForeignKey<ClinicianAssignments>(a => a.ClinicianId);

            modelBuilder.Entity<ClinicianProfile>()
                .HasOne(c => c.Verification)
                .WithOne(v => v.Clinician)
                .HasForeignKey<ClinicianVerification>(v => v.ClinicianId);



        }

    }

}


