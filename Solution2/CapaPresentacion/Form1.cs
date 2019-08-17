using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        entidad ent = new entidad();
        negocio neg = new negocio();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login(); 
        }

        public void login()
        {
            int a;
            ent.usuario = textBox1.Text;
            ent.pasword = textBox2.Text;
            a = neg.N_login(ent);
            if (a == 1)
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("usuario/contraseña incorrecto...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
