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

            PrecioFinalTV(presFinal, precio_, cons, peso_, reso_, sinTDT);

        }


        private void PrecioFinalTV(int presFin, int presBas, string cons, int pes, int reso_ , bool tdt)
        {
            presFin = presBas;

            if (cons == ConsumoOpciones[0])
            {
                presFin = presFin + 10;
            }
            else if (cons == ConsumoOpciones[1])
            {
                presFin = presFin + 30;
            }
            else if (cons == ConsumoOpciones[2])
            {
                presFin = presFin + 50;
            }
            else if (cons == ConsumoOpciones[3])
            {
                presFin = presFin + 60;
            }
            else if (cons == ConsumoOpciones[4])
            {
                presFin = presFin + 80;
            }
            else if (cons == ConsumoOpciones[5])
            {
                presFin = presFin + 100;
            }


            if (pes <= 19)
            {
                presFin = presFin + 10;
            }
            else if (pes > 19 && pes <= 49)
            {
                presFin = presFin + 50;
            }
            else if (pes > 49 && pes <= 79)
            {
                presFin = presFin + 80;
            }
            else if (pes > 80)
            {
                presFin = presFin + 100;
            }

            if (reso_ > 40)
            {
                presFin = presFin + Convert.ToInt32(Math.Round(presFin*0.30));
            }

            if(tdt != true)
            {
                presFin = presFin + Convert.ToInt32(Math.Round(presFin * 0.5));
            }



            MessageBox.Show("El precio del electrodoméstico es de: $ " + presFin);
        }



       
    }
}
