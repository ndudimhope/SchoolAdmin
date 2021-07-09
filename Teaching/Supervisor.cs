using SchoolAdmin.Learning;
using SchoolAdmin.Lookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Teaching
{
    public class Supervisor:ITeacher
    {
        // NOTE: Full implementation of this class was deliberately left out as an exercise for the learners
        public int StaffId
        {
            get;
        }

        public string Name
        {
            get;
        }

        public SchoolSubject Subject
        {
            get;
            set;
        }
        public List<ILearner> Learners
        {
            get;
            set;
        }

        public void Teach()
        {

        }

        public void Supervise()
        {

        }
    }
}
