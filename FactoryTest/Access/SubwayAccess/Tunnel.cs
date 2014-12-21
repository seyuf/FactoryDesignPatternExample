using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// couloir/chemin dans le metro 
namespace FactoryTest.Access
{
    class Tunnel:Access
    {
        int height;
        int width;
        public Tunnel(int x1 = 0, int y1 = 0, int heightIn = 0, int widthIn = 0, string nameIn ="couloir"):base(x1, y1, nameIn) {
            height = heightIn;
            width = heightIn;
        }
    }
}
