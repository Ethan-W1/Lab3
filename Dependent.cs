using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Dependent : Person
    {
        public Dependent()
        {
            Random rand = new Random();
            DateTime dateToday = DateTime.Now;
            // birthdate up to 10+ years.
            int future = rand.Next(dateToday.Year, dateToday.Year + 10);
            int month = rand.Next(1, 12);
            int day = rand.Next(1, 31);

            BirthDate = new DateTime(future, month, day);
        }
    }
}