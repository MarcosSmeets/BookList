using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Model
{
    public class book
    {
        [Key]
        public int idBook { get; set; }
        [Required]
        public string bookName { get; set; }
        public string authorName { get; set; }
        public string sinopseBook { get; set; }
        public string genre { get; set; }
        public int yearRelease { get; set; }
        public string famousQuote { get; set; }
    }
}
