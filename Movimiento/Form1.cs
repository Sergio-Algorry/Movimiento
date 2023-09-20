using BackEnd;
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
        public Form1()
        {
            InitializeComponent();
        }

        private async void btIniciar_Click(object sender, EventArgs e)
        {
            btIniciar.Visible = false;

            Figura F1 = new Figura();
            F1.PasoH = 10;
            F1.PasoV = 10;
            F1.PosicionH = 0;
            F1.PosicionV = 0;
            F1.Figu.BackColor = Color.Red;
            F1.Figu.Text = "";
            F1.Figu.Height = 50;
            F1.Figu.Width = 50;
            Controls.Add(F1.Figu);

            Figura F2 = new Figura();
            F2.PasoH = 10;
            F2.PasoV = 5;
            F2.PosicionH = 250;
            F2.PosicionV = 250;
            F2.Figu.BackColor = Color.Blue;
            F2.Figu.Height = 20;
            F2.Figu.Width = 20;
            F2.Figu.Text = "";
            Controls.Add(F2.Figu);

            for (int i = 0; i < 10000; i++)
            {
                F1.Mover(this.Width, this.Height);
                F2.Mover(this.Width, this.Height);

                //this.Refresh();
                await Task.Delay(velocidad);
            }
        }
    }
}
