using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_EF_Project2.Models
{
    internal class Loan
    {
        // 2 foreign keys from the many to many relation (composite primary key defined in configurations for more readability)
        public int BookId { get; set; }
        public int BorrowerId { get; set; }

        //extra columns
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }

        // 1 to many relations between (Book and Loan) , (Borrower and Loan)
        public Book Book { get; set; }
        public Borrower Borrower { get; set; }
        //bec each loan has one book and one borrower 

    }
}
