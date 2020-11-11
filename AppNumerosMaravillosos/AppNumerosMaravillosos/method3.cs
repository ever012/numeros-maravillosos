﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNumerosMaravillosos
{
    public partial class method3 : Form
    {
        public method3()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            Int64 n, num, contador = 0, numero = 0;

            num = Convert.ToInt64(txtCantidad.Text);
            bool EsEntero = Int64.TryParse(txtCantidad.Text, out numero);

            if (!EsEntero || num <= 0)
            {
                lbxTexto.Items.Add("Esta mal,Ingrese numero entero, positivo, NO decimales y NO textos  ");
            }
            else
            {
                
                //1000000000
                lbxTexto.Items.Clear();
                for (int x = 0; x < num; x++)
                {
                   
                    contador++;
                    n = contador;
                    lbxTexto.Items.Add("N° " + contador);

                    while (n != 1)
                    {

                        if (n % 2 == 0)
                        {
                            n = n / 2;

                        
                        }
                        else if (n % 2 != 0)
                        {

                            n = (n * 3) + 1;

                        
                        }
                        lbxTexto.Items.Add(n);
                        if (n == 1) { lbxTexto.Items.Add("Es maravilloso"); lbxTexto.Items.Add(" "); }
                        else if (n < 1) { lbxTexto.Items.Add("No es maravilloso"); lbxTexto.Items.Add(" "); }
                         
                    }

                }

            }
           
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Longitud minima de numeros = 1000000000000000000 \nLongitud maxima de numeros = 9000000000000000000 ",
            "Ayuda",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Int64 n, num, contador = 0, numero = 0;

                num = Convert.ToInt64(txtCantidad.Text);
                bool EsEntero = Int64.TryParse(txtCantidad.Text, out numero);

                if (!EsEntero || num <= 0)
                {
                    lbxTexto.Items.Add("Esta mal,Ingrese numero entero, positivo, NO decimales y NO textos  ");
                }
                else
                {

                    //1000000000
                    lbxTexto.Items.Clear();
                    for (int x = 0; x < num; x++)
                    {

                        contador++;
                        n = contador;
                        lbxTexto.Items.Add("N° " + contador);

                        while (n != 1)
                        {

                            if (n % 2 == 0)
                            {
                                n = n / 2;


                            }
                            else if (n % 2 != 0)
                            {

                                n = (n * 3) + 1;


                            }
                            lbxTexto.Items.Add(n);
                            if (n == 1) { lbxTexto.Items.Add("Es maravilloso"); lbxTexto.Items.Add(" "); }
                            else if (n < 1) { lbxTexto.Items.Add("No es maravilloso"); lbxTexto.Items.Add(" "); }

                        }

                    }

                }
            }
        }


    }
}
