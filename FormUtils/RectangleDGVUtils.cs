using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramUtils;

namespace FormUtils1
{
    public class RectangleDGVUtils
    {
        public static List<Line> DGVToStudentsList(DataGridView dgv)
        {
            List<Line> lines = new List<Line>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                int X1 = (int)Convert.ChangeType(row.Cells["Column1"].Value, typeof(int));
                int Y1 = (int)Convert.ChangeType(row.Cells["Column2"].Value, typeof(int));
                //int X2 = (int)Convert.ChangeType(row.Cells["Column3"].Value, typeof(int));
                //int Y2 = (int)Convert.ChangeType(row.Cells["Column4"].Value, typeof(int));

                Line line = new Line(X1, Y1);
                lines.Add(line);
            }
            return lines;
        }

    }
}
