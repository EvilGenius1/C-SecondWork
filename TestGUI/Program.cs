using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGUI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Random rnd = new Random();

            int Nlength, NsquareMin;
            int Mpiramid, MApophemaMin;
            int a;
            int NmassivLength = rnd.Next(2, 10);
            int MmassivLength = rnd.Next(2, 10);

            int[] arrayN = new int[NmassivLength];
            int[] arrayM = new int[MmassivLength];

        }
    }
}
