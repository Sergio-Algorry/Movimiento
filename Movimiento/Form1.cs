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
            F1.Inicializar(Color.Red, this.Width, this.Height);
            await Task.Delay(velocidad);
            Controls.Add(F1.Figu);

            Figura F2 = new Figura();
            F2.Inicializar(Color.Blue, this.Width, this.Height);
            await Task.Delay(velocidad);
            Controls.Add(F2.Figu);

            Figura F3 = new Figura();
            F3.Inicializar(Color.Black, this.Width, this.Height);
            await Task.Delay(velocidad);
            Controls.Add(F3.Figu);


            Figura F4 = new Figura();
            F4.Inicializar(Color.Yellow, this.Width, this.Height);
            await Task.Delay(velocidad);
            Controls.Add(F4.Figu);

            this.Refresh();

            for (int i = 0; i < 10000; i++)
            {
                F1.Mover(this.Width, this.Height);

                F2.Mover(this.Width, this.Height);

                F3.Mover(this.Width, this.Height);

                F4.Mover(this.Width, this.Height);

                this.Refresh();
                await Task.Delay(velocidad);
            }
        }
    }
}
