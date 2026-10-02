using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day04_EF_Project3.Models;     //dont forgettttt
using Microsoft.EntityFrameworkCore; //dont forgettttttttt
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day04_EF_Project3.Configurations
{
    internal class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>   
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(A => new { A.PatientId, A.DoctorId });
        }
    }
}
