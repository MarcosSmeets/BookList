using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Model
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public int idAccount { get; set; }
        [Required]
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}
