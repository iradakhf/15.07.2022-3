using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    internal class DemoEncap
    {
        //private variable declared
        //these can only be accessed by public method of class

        private string StudentName;
        private int StudentAge;

        //using accessors to get and set the value of studentName
        public string Name{ get; set; }
        public int Age { get; set; }

    }
}
