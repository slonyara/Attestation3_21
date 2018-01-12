using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace ProgramUtils
{
    public class RectangleDGVUtils
    {
        public static List<Rectangle> DGVToStudentsList(DataGridView dgv)
        {
            List<Rectangle> rectangles = new List<Rectangle>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                int X1 = (int)Convert.ChangeType(row.Cells["Column1"].Value, typeof(int));
                int Y1 = (int)Convert.ChangeType(row.Cells["Column2"].Value, typeof(int));
                int X2 = (int)Convert.ChangeType(row.Cells["Column3"].Value, typeof(int));
                int Y2 = (int)Convert.ChangeType(row.Cells["Column4"].Value, typeof(int));

                Rectangle rectangle = new Rectangle(X1, Y1, X2, Y2);
                rectangles.Add(rectangle);
            }
            return rectangles;
        }

    }
}
