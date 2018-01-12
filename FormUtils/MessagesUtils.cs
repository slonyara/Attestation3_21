using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUtils1
{
    public class MessagesUtils
    {
        public static void Show(string message)
        {
            MessageBox.Show(message);
        }

        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
