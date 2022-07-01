using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Propaganda
{
    static class Program
    {

        public static Banners frmBanners;
      
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(frmBanners =new Banners());
        }

        public static void mostrarImagen(string ruta)
        {

          

          frmBanners. pic1.Image = Image.FromFile(ruta);

        }

    }
}
