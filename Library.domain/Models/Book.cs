using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.domain.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }

        public string Category { get; set; }

        public bool IsAvailable { get; set; }

        public ICollection<Loan> Loans { get; set; } = new List<Loan>();


    }
}
