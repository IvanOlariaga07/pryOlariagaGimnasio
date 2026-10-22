using System;
using System.Windows.Forms;

namespace pryOlariagaGimnasioGuia
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmInscripcion());
        }
    }
}
