using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Menu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clearColor();
            label1.ForeColor = Color.Black;
            negroToolStripMenuItem.Checked = true;
            label1.Font = new Font("Times New Roman",20);
            timesNewRomanToolStripMenuItem.Checked = true;
            
            
        }

        private void salirAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cambiarTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = Interaction.InputBox("Ingresa una cadena", "Cambiar Texto");
        }

        private void créditosF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fue hecho por Edgar");
        }

        public void clearColor()
        {
            negroToolStripMenuItem.Checked = false;
            verdeToolStripMenuItem.Checked = false;
            azulToolStripMenuItem.Checked = false;
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            label1.ForeColor = Color.Black;
            negroToolStripMenuItem.Checked = true;
        }


        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            label1.ForeColor = Color.Blue;
            azulToolStripMenuItem.Checked = true;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            label1.ForeColor = Color.Green;
            verdeToolStripMenuItem.Checked = true;
        }

        private void clearFont()
        {
            timesNewRomanToolStripMenuItem.Checked = false;
            coutierToolStripMenuItem.Checked = false;
            comicSansToolStripMenuItem.Checked = false;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFont();
            label1.Font = new Font("Times New Roman",20);
            timesNewRomanToolStripMenuItem.Checked = true;
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFont();
            label1.Font = new Font("Comic Sans MS", 20);
            comicSansToolStripMenuItem.Checked = true;
        }

        private void coutierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFont();
            label1.Font = new Font("Courier New", 20);
            coutierToolStripMenuItem.Checked = true;

        }
    }
}
