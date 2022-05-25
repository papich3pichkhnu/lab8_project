using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal sealed class Student : Person
    {
        public int Id { get; set; }
        public int FacultyId { get; set; }
        public Faculty? Faculty { get; set; } = null;
        public AssociateProfessor? Mentor { get; set; } = null;
        

    }
}
