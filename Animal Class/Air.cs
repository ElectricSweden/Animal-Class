using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Class
{
    class Air : Land
    {
        protected double wingSpan_;
        protected float flyTime_;
        protected double flySpeed_;
        protected int flyHeight_;

        public void Fly()
        {
            Console.WriteLine("Djuret flyger.");
        }
    }
}
