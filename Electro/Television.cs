using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Electro
{
    class Television : Electrodomestico
    {


        int resolucion=20;
        bool sintTDT;
        int presFinal;
        public int Resolucion { get => resolucion; }
        public bool SintTDT { get => sintTDT; }

        public Television(int peso_, int precio_, string color_, string cons, int reso_, bool sinTDT)
        {
            if(reso_ == 0)
            {
                reso_ = resolucion;
            }

            ComprobarConsumo(cons);
            ComprobarColor(color_);

            PrecioFinal(presFinal, precio_, cons, peso_, reso_, sinTDT);
            MessageBox.Show("El precio del electrodoméstico es de: $ " + presFinal);

        }


        public int PrecioFinal(int presFin, int presBas, string cons, int pes, int reso_ , bool tdt)
        {
            PrecioFinal( presFin, presBas, cons, pes);
            presFin = PrecioFinal1;
                       
            if (reso_ > 40)
            {
                presFin = presFin + Convert.ToInt32(Math.Round(presBas*0.30));
            }

            if(tdt != true)
            {
                presFin = presFin + Convert.ToInt32(Math.Round(presBas * 0.5));
            }
            presFinal = presFin;

            return presFinal;
           
        }



       
    }
}
