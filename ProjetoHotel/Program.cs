using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHotel
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            LES les = new LES();
            LDE lde = new LDE();
            FEC fec = new FEC();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(les, lde, fec));
        }
    }
}
