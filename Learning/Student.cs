using SchoolAdmin.Facilities;
using SchoolAdmin.Lookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Learning
{
    class Student:ILearner
    {
        private readonly int _regNumber;
        private readonly string _fullName;
        private StudentLevel _level;


        public Student(int regNumber, string fullName)
        {
            _regNumber = regNumber;
            _fullName = fullName;
        }


        public int RegNumber
        {
            get => _regNumber;
        }


        public string Name
        {
            get => _fullName;
        }


        public StudentLevel Level
        {
            get
            {
                return _level;
            }

            set
            {
                _level = value;
            }
        }


        public void Learn()
        {
            // Additional instructions can go here
            Console.WriteLine("I am learning something interesting now.");
        }

        public void ReceiveNewBookAlert(object source, BookEventArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
