using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstToDb
{
    using Data.Models;

    class Program
    {
        static void Main(string[] args)
        {
            PhoneBookModel model = new PhoneBookModel();

            //{CodeFirstToDb.Data.Models.Male}
            Male male = model.Males.Find(1);
            Console.WriteLine(male.Name);

            //Phone phone = model.Phones.Find(male.PersonID); //first phone
            //Console.WriteLine("Phone {0} - ", phone.Number);

            Console.ReadKey();

        }
    }
}
