using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singalton
{
    class Program
    {
        static void Main(string[] args)
        {
             Singolton.callsingleton();
            Console.ReadLine();
        }
    }

    class Singolton {
        private Singolton() {

        }

        private static Singolton singleobj =new Singolton();

        public static void callsingleton() {
            Console.WriteLine("I'm singolton");

        }
    }
}
