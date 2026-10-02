using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_EF_Project2.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("Author")]    //you dont have to. it is already named properly as a foreign key
        public int AuthorId { get; set; }

        public Author Author { get; set; }

        //one to amny relation with loan
        public List<Loan> Loans { get; set; }
    }
}
