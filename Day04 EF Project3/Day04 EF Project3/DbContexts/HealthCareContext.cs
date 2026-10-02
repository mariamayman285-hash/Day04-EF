using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day04_EF_Project3.Configurations;
using Day04_EF_Project3.Models;
using Microsoft.EntityFrameworkCore;

namespace Day04_EF_Project3.DbContexts
{
    internal class HealthCareContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=HealthCareDB;Trusted_Connection=True;");
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //u can put the composite key configuration in here but it is more readable to put it in configurations folder

            modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
        }
    }
}
