using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Dependent : Person
    {
        public Dependent(string firstName = "", string lastName = "", int age = 0, string social ="", string dependentPhone = "")
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateTime BirthDate = age + 10;
            this.SSN = social;
            this.Phone = dependentPhone;
        }
    }
}