using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop_5.project_1.Interfaces
{
    internal interface IDuration
    {


        int Hours { get; set; }
        int Minutes { get; set; }
        int Seconds { get; set; }
        string ToString();
        bool Equals(object obj);
        int GetHashCode();


    }
}
