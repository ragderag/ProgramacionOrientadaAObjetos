﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public string usuario = "Edgar";
        public string pass = "hola123.,";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = TBUser.Text;
            string password = TBPass.Text;

            if (user == usuario && password == pass)
            {
                MessageBox.Show("Acceso correcto");
            }
            else 
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}
