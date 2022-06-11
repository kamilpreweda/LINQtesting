using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtesting
{
    internal class PrintWhenGetting
    {
        private int insantceNumber;
        public int InsantceNumber
        {
            set { insantceNumber = value; }
            get
            {
                Console.WriteLine($"Pobieranie nr {insantceNumber}");
                return insantceNumber;
            }
        }
    }
}
