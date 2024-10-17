using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NITIV
{
     class LoopingExamples
    {

        public  int AddAndAverage(int a, int b, ref int addResult)
        {
            addResult = a + b;
            return addResult/2;
        }


        public LoopingExamples()
        {
            
        }

        public LoopingExamples(int x) : this()
        {

        }
        public void ExForEach()
        {
            var processes = from p in System.Diagnostics.Process.GetProcesses()
                            select p.ProcessName;

            foreach (var process in processes)
            {
                Console.WriteLine(process);
            }

        }

        public void ExJaggedArray()
        {
            int[][] matrix = new int[3][];
            matrix[0]  = new int[2];
            matrix[0][0] = 10;
            matrix[0][1] = 20;

            matrix[1]  = new int[] { 5, 7, 8 };


        }


        public int Add(int x, int y)
        {
            return x+ y;
        }

        public int Add(int x, int y, int z)
        {
            return x + y+z;
        }

        internal int AddAndAverage(int a, int b, ref int addRes, out int max)
        {
            max= 0;
            max = a>b ?a:b;
            addRes = a + b;
            return addRes / 2;
        }

        /*
         * matrix[0] ==> two elements array
         * matrix[1] ==> 5 elements array
         */
    }
}
