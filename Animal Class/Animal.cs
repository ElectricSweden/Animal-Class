using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Class
{
    class Animal
    {
        protected string name_;
        protected string color_;
        protected uint age_;

        public void Eat()
        {
            Console.WriteLine("Nu äter djuret.");
        }

        public void Sleep()
        {
            Console.WriteLine("Djuret sover.");
        }
    }
}
