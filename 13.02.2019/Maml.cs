using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2019
{
    public abstract class Maml
    {
        public Maml()
        {
            Console.WriteLine("2");
        }

        public Maml(int Someprop)
        {
            Console.WriteLine("3");
        }

        public Maml(string Someprop)
        {
            Console.WriteLine("4");
        }


        private int Someprop { get; set; }
    }
    
}
