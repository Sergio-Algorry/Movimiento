using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movimiento
{
    public partial class Form1 : Form
    {
        int velocidad = 100;

        int pasoH = 10;
        int posicionH = 0;

        int pasoV = 10;
        int posicionV = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btIniciar_Click(object sender, EventArgs e)
        {
            btIniciar.Visible = false;

            Label figura = new Label();
            figura.BackColor = Color.Red;
            figura.Text = "";

            figura.Width = 50;
            figura.Left = posicionH;

            figura.Height = 50;
            figura.Top = posicionV;

            Controls.Add(figura);

            for (int i = 0; i < 10000; i++)
            {
                posicionH = posicionH + pasoH;
                figura.Left = posicionH;

                posicionV = posicionV + pasoV;
                figura.Top = posicionV;


                if (posicionH + figura.Width > this.Width)
                {
                    pasoH = -1 * pasoH;
                }
                else if (posicionH < 0)
                {
                    pasoH = -1 * pasoH;
                }

                if (posicionV + figura.Height > this.Height)
                {
                    pasoV= -1 * pasoV;
                }
                else if (posicionV < 0)
                {
                    pasoV = -1 * pasoV;
                }

                //this.Refresh();
                await Task.Delay(velocidad);
            }
        }
    }
}
