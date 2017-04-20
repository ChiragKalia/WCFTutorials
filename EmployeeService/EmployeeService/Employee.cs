using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{ 
    public class Employee
    {

        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        private string _gender;
        public string gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private DateTime _dateOfBirth;
        public DateTime dateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
    }
}
