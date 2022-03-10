using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Water w = new Water();
            Shark s = new Shark();

            List<Animal> animals = new List<Animal>();
            animals.Add(a);
            animals.Add(w);
            animals.Add(s);
            s.Attack();
            Console.ReadLine();
        }
    }
}
