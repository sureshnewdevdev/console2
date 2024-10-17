using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NITIV
{
	interface IParent
	{

	}
	interface IChild : IParent 
	{ 
	}

    interface IGrantChild : IChild
    {

    }


    public class Father
	{

	}

	public class Son : Father
    {

	}

    public class Daughter : Father
    {

    }
}
