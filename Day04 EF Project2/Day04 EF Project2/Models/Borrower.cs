using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_EF_Project2.Models
{
    internal class Borrower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime MembershipDate { get; set; }

        //one to amny relation with loan
        public List<Loan> Loans { get; set; }
    }
}
