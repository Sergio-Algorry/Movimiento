using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackEnd
{
    public class Figura
    {
        public int PasoH { get; set; }
        public int PosicionH { get; set; }
        public int PasoV { get; set; }
        public int PosicionV { get; set; }

        public Label Figu { get; set; } = new Label();

        private Random rnd = new Random();

        public void Inicializar(Color aColor, 
                                int aAnchoVentana, 
                                int aAltoVentana)
        {
            PasoH = rnd.Next(0, 20);
            PasoV = rnd.Next(0, 20);
            PosicionH = rnd.Next(0, aAnchoVentana-100);
            PosicionV = rnd.Next(0, aAltoVentana-100);
            Figu.BackColor = aColor;
            Figu.Text = "";
            Figu.Height = rnd.Next(20, 50);
            Figu.Width = Figu.Height;
            //Figu.Width  = rnd.Next(20, 50);
            Figu.Refresh();
        }

        public void Mover(int AnchoForm, int AltoForm )
        {
            PosicionH = PosicionH + PasoH;
            Figu.Left = PosicionH;

            PosicionV = PosicionV + PasoV;
            Figu.Top = PosicionV;


            if (PosicionH + Figu.Width > AnchoForm)
            {
                PasoH = -1 * PasoH;
            }
            else if (PosicionH < 0)
            {
                PasoH = -1 * PasoH;
            }

            if (PosicionV + Figu.Height > AltoForm)
            {
                PasoV = -1 * PasoV;
            }
            else if (PosicionV < 0)
            {
                PasoV = -1 * PasoV;
            }

        }
    }
}
