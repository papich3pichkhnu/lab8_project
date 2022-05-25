using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal abstract class Person
    {
        private int _age = 18;
        public int Age { get { return _age; } set { if (value > 0) _age = value; } }
        protected int _height = 170;
        public int Height { get { return _height; } set { if (value > 0) _height = value; } }
        public string ColorOfEyes { get; set; } = "Brown";
        public string ColorOfHair { get; set; } = "Black";
        public string LastName { get; set; } = "Herringhton";
        public string FirstName { get; set; } = "Billy";
        public string MiddleName { get; set; } = "Glen";
        public string Sex { get; set; } = "Male";        
        public string FullName { get { return LastName + " " + FirstName + " " + MiddleName; } }
    }
}
