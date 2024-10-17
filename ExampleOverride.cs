using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NITIV
{
    public class ExampleOverride
    {

        public virtual string MyCurrentCompany()
        {
            return "CapG";
        }
    }

    public class DrivedClass  : ExampleOverride
    {
        public override string MyCurrentCompany()
        {
            return "Genie";
        }
    }
}
