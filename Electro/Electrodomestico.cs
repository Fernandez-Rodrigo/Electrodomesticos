using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Electro
{
    class Electrodomestico
    {
        int precioBase;
        enum ColorOpci { Blanco, Negro, Rojo, Azul, Gris};
        enum ConsumoOpc { F, E, D, C, B, A}
        string color;
        string consumo;
        int peso;
        int precioFinal;
       

        public int PrecioBase { get => precioBase;}
    
        public string Color { get => color; }
     
        public string Consumo { get => consumo; }
        public int Peso { get => peso; }
        public int PrecioFinal1 { get => precioFinal; set => precioFinal = value; }




        public Electrodomestico()
        {

        }

        public Electrodomestico(string color_ , string consumo_, int precio_ , int peso_)
        {
           
            switch (precio_)
            {
                case 0:
                    precio_ = 100;
                    break;
            }

            switch (peso_)
            {
                case 0:
                    peso_ = 5;
                    break;
            }

            ComprobarConsumo(consumo_);
            ComprobarColor(color_);

            PrecioFinal(precioFinal, precio_, consumo_, peso_);


            MessageBox.Show("El precio del electrodoméstico es de: $ " + precioFinal);

        }




        protected void ComprobarConsumo(string letra)
        {


            foreach(string a in Enum.GetNames(typeof(ConsumoOpc)))
            {
                if(letra == a)
                {
                    MessageBox.Show("El consumo seleccionado está representado por la letra: " + letra);
                }
            }
           



        }



        protected void ComprobarColor(string c)
        {

            foreach (string a in Enum.GetNames(typeof(ColorOpci)))
            {
                if (c == a)
                {
                    MessageBox.Show("El color seleccionado es: " + c);
                }
            }
        }


        private protected virtual int PrecioFinal(int presFin, int presBas, string cons, int pes)
        {
            presFin = presBas;

            if(cons == Convert.ToString(ConsumoOpc.F))
            {
                presFin = presFin + 10;
            }
            else if(cons == Convert.ToString(ConsumoOpc.E))
            {
                presFin = presFin + 30;
            }
            else if (cons == Convert.ToString(ConsumoOpc.D))
            {
                presFin = presFin + 50;
            }
            else if (cons == Convert.ToString(ConsumoOpc.C))
            {
                presFin = presFin + 60;
            }
            else if (cons == Convert.ToString(ConsumoOpc.B))
            {
                presFin = presFin + 80;
            }
            else if (cons == Convert.ToString(ConsumoOpc.A))
            {
                presFin = presFin + 100;
            }


            if(pes <= 19)
            {
                presFin = presFin + 10;
            }
            else if(pes > 19 && pes <= 49)
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

            PrecioFinal1 = presFin;
            return PrecioFinal1;
            
           



        }


    }
}
