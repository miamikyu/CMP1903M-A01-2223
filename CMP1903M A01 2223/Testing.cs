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
        private Pack fyPack;
        public Testing()
        {
            testPack = new Pack();
            fyPack = new Pack();  
        }
        public void runTests()
        {
            testPack.showCards();
            fyPack.showCards();
        }
    }
}
