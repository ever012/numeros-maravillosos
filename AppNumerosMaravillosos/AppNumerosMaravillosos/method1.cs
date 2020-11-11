using System;
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
    public partial class method1 : Form
    {
        public method1()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
             Int64 n, contador,numero=0;

                n = Convert.ToInt64(txtNumero.Text);
                bool EsEntero = Int64.TryParse(txtNumero.Text, out numero);

                if (!EsEntero || n <= 0)
                {
                    lbxTexto.Items.Add("Esta mal,Ingrese numero entero, positivo, NO decimales y NO textos  ");
                }
                else
                {
                    lbxTexto.Items.Clear();
            
                contador = n;
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
                        lbxTexto.Items.Add(n.ToString());
                        if (n == 1) { lbxTexto.Items.Add(n.ToString( "Es maravilloso" + "\n")); }
                        else if (n < 1) { lbxTexto.Items.Add(n.ToString( "No es maravilloso" + "\n")); }

                    }
                }

        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Longitud minima de numeros = 1000000000000000000 \nLongitud maxima de numeros = 9000000000000000000 ",
            "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Int64 n, contador, numero = 0;

                n = Convert.ToInt64(txtNumero.Text);
                bool EsEntero = Int64.TryParse(txtNumero.Text, out numero);

                if (!EsEntero || n <= 0)
                {
                    lbxTexto.Items.Add("Esta mal,Ingrese numero entero, positivo, NO decimales y NO textos  ");
                }
                else
                {
                    lbxTexto.Items.Clear();

                    contador = n;
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
                        lbxTexto.Items.Add(n.ToString());
                        if (n == 1) { lbxTexto.Items.Add(n.ToString("Es maravilloso" + "\n")); }
                        else if (n < 1) { lbxTexto.Items.Add(n.ToString("No es maravilloso" + "\n")); }

                    }
                }
            }

        }

    }
}
