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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMazimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            method1 m1 = new method1();
            m1.Show();
            this.Hide();
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            method2 m2 = new method2();
            m2.Show();
            this.Hide();
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            method3 m3 = new method3();
            m3.Show();
            this.Hide();
        }


    }
}
