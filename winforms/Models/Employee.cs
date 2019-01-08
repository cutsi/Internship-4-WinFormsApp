using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Employee
    {
        public Employee(string firstName, string lastName, DateTime dateOfBirth, int oib, string position)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Oib = oib;
            Position = position;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Oib { get; set; }
        public string Position { get; set; }
    }
}
