using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Class
{
    class Water : Animal
    {
        protected float breathTime_;

        public void Swim()
        {
            Console.WriteLine("Nu simmar vattendjuret.");
        }
    }
}
