using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Class
{
    class Shark : Fish
    {
        protected bool hostile_;

        public void Attack()
        {
            Console.WriteLine("Hajen attackerar.");
        }
    }
}
