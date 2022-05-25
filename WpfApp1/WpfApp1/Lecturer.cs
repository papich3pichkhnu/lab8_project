using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Lecturer : Person
    {
        public int Id { get; set; }
        public Department? Department { get; set; } = null;        
        
    }
}
