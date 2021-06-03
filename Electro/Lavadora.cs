using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace Electro
{
    class Lavadora : Electrodomestico
    {
        int carga = 5;
        int precioFinalLav;
        public int Carga { get => carga; }
        public int PrecioFinal2 { get => precioFinalLav; }

        public Lavadora(int carga_, int peso_ , int precio_ , string color_ , string cons_)
        {
            if(carga_ == 0)
            {
                carga_ = Carga;
            }

            ComprobarConsumo(cons_);
            ComprobarColor(color_);

            
            PrecioFinal(precioFinalLav, precio_, cons_, peso_, carga_);

            MessageBox.Show("El precio del electrodoméstico es de: $ " + precioFinalLav);

        }     

        public int PrecioFinal(int precFin, int precBas, string cons, int pes, int carg)
        {
            PrecioFinal(precFin, precBas, cons, pes);
            precioFinalLav = PrecioFinal1;


            if (carg > 30)
            {
               precioFinalLav  = precioFinalLav + 50;
            }
            
            return precioFinalLav;
        }

    }
}
