using assignment_oop_5.project_1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop_5.project_1.Interfaces
{
    internal interface IPoint3D : IComparable<Point3D> , ICloneable
    {
    
        int X { get; set; }
        int Y { get; set; }
        int Z { get; set; }
    }
}
