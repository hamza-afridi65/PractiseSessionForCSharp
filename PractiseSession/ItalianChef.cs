using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseSession
{
    class SpecialChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Can Make Pasta");
        }
        public override void MakesSpecial()
        {
            Console.WriteLine("Special Shef can make Special things");
        }
        
    }
}
