using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adjacency
{
    internal class Program
    {
        static bool[,] mGraph = new bool[,]
        {
        //              turqoise  orange   yellow   grey     lBlue    dBlue    green    pink   
        /* turqoise */{  false,   false,    true,    true,   false,   false,   false,   false},
        /* orange   */{  false,   false,    true,    true,   false,   false,   false,   false},
        /* yellow   */{  false,    true,   false,   false,   false,    true,   false,   false},
        /* grey     */{  false,    true,   false,   false,    true,   false,   false,   false},
        /* lBlue    */{  false,   false,   false,   false,   false,   false,    true,   false},
        /* dBlue    */{  false,   false,   false,   false,   false,   false,   false,    true},
        /* green    */{  false,   false,   false,   false,   false,    true,   false,   false},
        /* pink     */{  false,   false,   false,   false,   false,   false,   false,   false}
        };
        static void Main(string[] args)
        {

        }
    }
}
