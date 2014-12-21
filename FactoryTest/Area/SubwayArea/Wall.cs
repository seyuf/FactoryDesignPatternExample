using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTest.Area
{
    class Wall:Frame
    {
        string color;
        public Wall(int x = 0, int y = 0, string nameIn = "mur") : base(x, y, nameIn) {
            color = "white";
        }
    }
}
