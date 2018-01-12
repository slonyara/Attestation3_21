using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramUtils;
namespace ProgramUtils
{
    public class  ProgramLogic
    {
        public IList<Line> line{ get; set; }

        public ProgramLogic(List<Line> list)
        {
            line = list;
            
        }
        public string Result()
        {
            string l1 = null;
            string l2 = null;
            string l3 = null;
            int max = 0 ;
            int k = 0;
            string Result = "Oтвет:";
            for (int r = 0; r < line.Count; r++)
            {
                for (int rr = 1; rr < line.Count; rr++)
                {
                    if (line[r].P1.Y < line[rr].P1.X || line[r].P1.X > line[rr].P1.Y)
                    {
                       for (int rrr = rr+1; rrr < line.Count; rrr++)
                       {
                            if (line[r].P1.Y < line[rrr].P1.X || line[r].P1.X > line[rrr].P1.Y)
                            {
                                k = line[r].P1.Y - line[r].P1.X + line[rr].P1.Y - line[rr].P1.X + line[rrr].P1.Y - line[rrr].P1.X;
                                if (k > max)
                                {
                                    max = k;
                                     l1 = r.ToString();
                                     l2 = rr.ToString();
                                     l3 = rrr.ToString();
                                }
                            }
                       }
                    }
                }

                Result = l1 + " " + l2 + " " + l3 + " ( Длина " + max + ")";

            }
            return Result;
        }
        
    }
}
