using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Lookup
{
    public class Author
    {
        public string FullName { get; set; }

        public IEnumerable<Book> Books { get; set; }

    }
}
