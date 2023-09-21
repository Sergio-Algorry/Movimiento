using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class ListaFiguras
    {
        public Figura[] lista { get; set; } = new Figura[5];

        public async void GenerarFiguras(Color aColor,
                                int aAnchoVentana,
                                int aAltoVentana) 
        {
            for (int i = 0; i < 5; i++)
            {
                Figura F = new Figura();
                F.Inicializar(aColor, aAnchoVentana, aAltoVentana);
                await Task.Delay(100);
                lista[i] = F;   
            }
        }
    }
}
