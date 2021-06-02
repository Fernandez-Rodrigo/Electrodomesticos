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


            PrecioFinalLav(precioFinalLav, precio_, cons_, peso_, carga_);

        }



        protected  void  PrecioFinalLav(int presFin, int presBas, string cons, int pes, int carg)
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

            if(carg > 30)
            {
                presFin = presFin + 50;
            }



            MessageBox.Show("El precio del electrodoméstico es de: $ " + presFin);



        }

    }
}
