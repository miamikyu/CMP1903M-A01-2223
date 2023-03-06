using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Testing
    {
        private Pack testPack;
        public Testing()
        {
            testPack = new Pack();
        }
        public void runTests()
        {
            testPack.showCards();
        }
    }
}
