using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classexamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mike Coffey";
            var parts = name.ToLower().Split(' ');
            parts[0] = "mike";
            parts[1] = "coffey";
        }
    }
}
