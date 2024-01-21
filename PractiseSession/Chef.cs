using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseSession
{
    class Chef
    {
        public void MakeSalad()
        {
            Console.WriteLine("Can Make Salad");
        }
        public void MakeSandwich()
        {
            Console.WriteLine("Can Make Sandwich");
        }
        public virtual void MakesSpecial()
        {
            Console.WriteLine("Can Make Special BBQ");
        }
    }
}
