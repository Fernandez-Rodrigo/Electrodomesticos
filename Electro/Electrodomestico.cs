using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Electro
{
    class Electrodomestico
    {
        int precioBase;
        List<string> colorOpciones = new List<string> {"Blanco", "Negro", "Rojo", "Azul", "Gris" };
        string color;
        List<string> consumoOpciones = new List<string> { "F", "E", "D", "C", "B", "A" };
        string consumo;
        int peso;
        int precioFinal;
        int carga;

        public int PrecioBase { get => precioBase;}
        public List<string> ColorOpciones { get => colorOpciones;  }
        public string Color { get => color; }
        public List<string> ConsumoOpciones { get => consumoOpciones; set => consumoOpciones = value; }
        public string Consumo { get => consumo; }
        public int Peso { get => peso; }
        public int PrecioFinal1 { get => precioFinal; set => precioFinal = value; }




        public Electrodomestico()
        {

        }

        public Electrodomestico(string color_ , string consumo_, int precio_ , int peso_)
        {
            /*color = color_;
            consumo = consumo_;
            precioBase = precio_;
            peso = peso_;
            */


            switch (color_)
            {
                case "": color_ = colorOpciones[0];
                    break;
            }

            switch (consumo_)
            {
                case "":
                    consumo_ = consumoOpciones[0];
                    break;
            }

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
            

            

        }




        protected void ComprobarConsumo(string letra)
        {
            if(consumoOpciones.Contains(letra) == false)
            {
                MessageBox.Show("El consumo no existe");
                MessageBox.Show(letra);
                return;
            }
            else
            {
                MessageBox.Show("El consumo seleccionado fue de categoría: " + letra);
            }
        }



        protected void ComprobarColor(string c)
        {
            if (colorOpciones.Contains(c) == false)
            {
                MessageBox.Show("El color no existe");
                MessageBox.Show(c);
                return;
            }
            else
            {
                MessageBox.Show("El color seleccionado fue: " + c);
            }

        }


        protected  void PrecioFinal(int presFin, int presBas, string cons, int pes)
        {
            presFin = presBas;

            if(cons == consumoOpciones[0])
            {
                presFin = presFin + 10;
            }
            else if(cons == consumoOpciones[1])
            {
                presFin = presFin + 30;
            }
            else if (cons == consumoOpciones[2])
            {
                presFin = presFin + 50;
            }
            else if (cons == consumoOpciones[3])
            {
                presFin = presFin + 60;
            }
            else if (cons == consumoOpciones[4])
            {
                presFin = presFin + 80;
            }
            else if (cons == consumoOpciones[5])
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

          

            
            MessageBox.Show("El precio del electrodoméstico es de: $ " + presFin);



        }


    }
}
