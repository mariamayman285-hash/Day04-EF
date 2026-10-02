using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day04_EF_Project2.Models;

namespace Day04_EF_Project2.Configurations
{
    internal class LoanConfigurations : IEntityTypeConfiguration<Loan>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Loan> builder)
        {
            builder.HasKey(L => new{ L.BookId , L.BorrowerId}); 
        }
    }
}
