using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningGenericsClass
{
    internal class TestGenerice
    {
        public bool Compare<Thing>(Thing t1, Thing t2)
        {
            return t1.Equals(t2);
        }
    }
}
