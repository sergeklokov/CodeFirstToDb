using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstToDb.Data.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonID { get; set; }

        [MaxLength(25)]
        public string Name { get; set; }

        public int Age { get; set; }
        public string Comment { get; set; }

        [NotMapped]
        public List<Phone> Phones { get; set; }

        public Person()
        {
            Phones = new List<Phone>();
        }

        public Person(int personID, string name)
        {
            PersonID = personID;
            Name = name;

            Phones = new List<Phone>();
        }
    }
}
