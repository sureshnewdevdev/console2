using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NITIV
{
    public class Person
    {

        private int id;

        public int Id 
        { 
            get
            {
                return id;
            }
            set
            {
                if (value>0)
                    id = value;
                else
                    id = 0;
            }  
        }
    }
}
