using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electro
{
    public partial class Form1 : Form
    {
        string radioCol = "Blanco";
        string radioCons = "F";
        string cons = "F";
        string col = "Blanco";
        int prec = 100;
        int pes = 5;
        int car = 5;
        int resol = 20;
        bool sintTDT = false;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            

            try
            {
                radioCol = grpColor.Controls.OfType<RadioButton>().First(n => n.Checked).Text;
                radioCons = grpConsumo.Controls.OfType<RadioButton>().First(n => n.Checked).Text;
                cons = Convert.ToString(radioCons);
                col = Convert.ToString(radioCol);
                prec = int.Parse(txtPrecioB.Text);
                pes = int.Parse(txtPeso.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Faltan datos o alguno de ellos es incorrecto");
                return;
            }
            
           
           

            
         
       
            

            if (grpTipo.Controls.OfType<RadioButton>().First(n => n.Checked).Text == "Lavadora")
            {
                try
                {
                    car = int.Parse(txtCarga.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Faltan datos o alguno de ellos es incorrecto");
                    return;
                }
                ComprobarValores(prec, pes, car, resol);
                Lavadora lava1 = new Lavadora(car, pes, prec, col, cons);
            }
            else if (grpTipo.Controls.OfType<RadioButton>().First(n => n.Checked).Text == "Television")
            {
                try
                {
                    resol = int.Parse(txtResol.Text);
                    sintTDT = grpSint.Controls.OfType<RadioButton>().First().Checked;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Faltan datos o alguno de ellos es incorrecto");
                    return;
                }
                ComprobarValores(prec, pes, car, resol);
                Television tv = new Television(pes, prec, col, cons, resol, sintTDT);
            }
            else
            {
                ComprobarValores(prec, pes, car, resol);
                Electrodomestico heladera = new Electrodomestico(col, cons, prec, pes);
            }
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int count = 0;
            
            List<RadioButton> listaRad = new List<RadioButton>();
            foreach (RadioButton r in grpTipo.Controls)
            {
                count++;
                listaRad.Add(r);
            }
            ComprobarNombre(listaRad, txtAgregar);


            if (txtAgregar.Text == "")
            {
                    MessageBox.Show("No hay nada para agregar, escriba un electrodoméstico");
            }
            else
            {

                    if (count >= 0 && count < 8)
                    {
                        RadioButton nuevo = new RadioButton();
                        grpTipo.Controls.Add(nuevo);
                        nuevo.Text = txtAgregar.Text;
                        listaRad.Add(nuevo);
                        switch (count)
                        {
                            case 0:
                                listaRad[0].Location = new Point(6, 12);
                                break;
                            case 1:
                                listaRad[1].Location = new Point(6, 37);
                                break;
                            case 2:
                                listaRad[2].Location = new Point(6, 62);
                                break;
                            case 3:
                                listaRad[3].Location = new Point(6, 87);
                                break;
                            case 4:
                                listaRad[4].Location = new Point(6, 112);
                                break;
                            case 5:
                                listaRad[5].Location = new Point(6, 137);
                                break;
                            case 6:
                                listaRad[6].Location = new Point(6, 162);
                                break;
                            case 7:
                                listaRad[7].Location = new Point(6, 187);
                                break;
                        }

                        txtAgregar.Text = "";
                    }



                    else
                    {
                        MessageBox.Show("No se pueden agregar más electrodomésticos");
                    }

                
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {


            if(txtSacar.Text == "Television" ||txtSacar.Text == "Lavadora")
            {
                MessageBox.Show("No se pueden eliminar los electrodomésticos predeterminados");
                txtSacar.Text = "";
                return;
            }

            int b;
            for (b = 0; b <= 2; b++)
            {
                List<RadioButton> listR = new List<RadioButton>();
                foreach (RadioButton r in grpTipo.Controls)
                {
                    listR.Add(r);

                }

               

                int largo = listR.Count;
                int f = 0;
                for (f = 0; f < largo; f++)
                {
                    if (listR[f].Text == txtSacar.Text)
                    {
                        grpTipo.Controls.Remove(listR[f]);
                        txtSacar.Text = "";

                    }



                }


                try
                {
                    listR[0].Location = new Point(6, 12);
                    listR[1].Location = new Point(6, 37);
                    listR[2].Location = new Point(6, 62);
                    listR[3].Location = new Point(6, 87);
                    listR[4].Location = new Point(6, 112);
                    listR[5].Location = new Point(6, 137);
                    listR[6].Location = new Point(6, 162);
                    listR[7].Location = new Point(6, 187);
                }
                catch (ArgumentOutOfRangeException)
                {

                }

                b++;

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ComprobarNombre(List<RadioButton> a, TextBox b)
        { int f;
            for(f = 0; f < a.Count; f++)
            {
                if (a[f].Text == b.Text)
                {
                    MessageBox.Show("Ya existe este electrodoméstico en la lista");
                    b.Text = "";
                }
            }
        }



        private void ComprobarValores(int pres, int pes, int carg, int resol_)
        {
            if (pres <= 0)
            {
                MessageBox.Show("El precio es menor o igual a 0, se completó automáticamente con su valor por defecto");
                txtPrecioB.Text = "100";
            }
            else if(pes <= 0)
            {
                MessageBox.Show("El peso es menor o igual a 0, se completó automáticamente con su valor por defecto");
                txtPeso.Text = "5";
            }
            else if(carg <= 0)
            {
                MessageBox.Show("La carga es menor o igual a 0, se completó automáticamente con su valor por defecto");
                txtCarga.Text = "5";
            } 
            else if(resol_ <= 0)
            {
                MessageBox.Show("La resolución es menor o igual a 0, se completó automáticamente con su valor por defecto");
                txtResol.Text = "20";
            }

    
               
               
                
        }

        private void radLava_CheckedChanged(object sender, EventArgs e)
        {
            if(radLava.Checked == true)
            {
                txtCarga.Enabled = true;
            }
            else
            {
                txtCarga.Enabled = false;
            }
        }

        private void radTv_CheckedChanged(object sender, EventArgs e)
        {
            if(radTv.Checked == true)
            {
                txtResol.Enabled = true;
                grpSint.Enabled = true;
            }
            else
            {
                txtResol.Enabled = false;
                grpSint.Enabled = false;
            }
        }
    }
}
