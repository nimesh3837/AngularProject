using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObejectOrientedProgramming
{
    internal class ProtectedClass
    {
        //Protected members can be accessed within that class or in the class that is deriving it.
        //But protected members can never be accessed by creating an object of the class.
        //Protected members can be accessed only through inheritance.

        protected ProtectedClass() { }
    }
}
