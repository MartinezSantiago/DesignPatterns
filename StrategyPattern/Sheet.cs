using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Sheet
    {
        private static Sheet sheet;
        private int perimeter=100;
        private Sheet()
        {

        }

        public static Sheet GetInstance()
        {
            if (sheet == null)
            {
                sheet = new Sheet();
            }
            return sheet;
        }
        public int Perimeter{
            get { return perimeter; }
            set { perimeter = value;Console.WriteLine("Perimeter Restante: "+ perimeter); }
            }

    }
}
