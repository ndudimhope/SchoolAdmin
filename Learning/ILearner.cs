using SchoolAdmin.Facilities;
using SchoolAdmin.Lookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Learning
{
    public interface ILearner
    {
        StudentLevel Level { get; set; }
        string Name { get; }
        int RegNumber { get; }

        void Learn();
        void ReceiveNewBookAlert(object source, BookEventArgs args);
    }
}
}
