using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstToDb.Data.Models
{
    [Table("Phone")]
    public class Phone
    {
        [Key]
        [Required]
        public string Number { get; set; }

        [ForeignKey("Male")]
        [Required]
        public int PersonID { get; set; }
        //public string Name { get; set; }

        public Male Male { get; set; }

        public Phone()
        {
        }

        public Phone(string number, int personID)
        {
            PersonID = personID;
            Number = number;
        }
    }
}
