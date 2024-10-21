using QLNhaSach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaSach
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new fTongHop("duy"));
=======
            Application.Run(new fThemTacGia());
>>>>>>> 4aa431f84c8e1036c96ec094b78802764dae02ee
        }
    }
}
