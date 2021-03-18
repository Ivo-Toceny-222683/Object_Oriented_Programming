using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6_Interfaces
{
    abstract class Object3D : GrObject
    {
        public abstract double GetSurface();

        public abstract double GetVolume();
    }
}
