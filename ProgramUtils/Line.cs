using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUtils
{
    public class Line
    {
       public Point P1 { get; set;  }
        
          
       /*
        List<int> GetPointsList() {
            return new List<int>() { P1.X, P1.Y, P2.X, P2.Y };
        }
        */
        public Line(int x1, int y1)
        {
            P1 = new Point(x1, y1);  
        }

    }
}
