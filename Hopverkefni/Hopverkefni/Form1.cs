using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hopverkefni
{
    public partial class Form1 : Form
    {
        bool lota  = true;

        int lotuteljari = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTveir1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (lota)
                b.Text = "X";
            else
                b.Text = "O";
            lota = !lota;
            b.Enabled = false;

            atugasigur();
        }

        private void atugasigur()
        {
            bool sigurvegari = false;
            //larétt
            if ((btnTveir11.Text == btnTveir2.Text) && (btnTveir2.Text == btnTveir3.Text))
            { 
                sigurvegari = true;
                MessageBox.Show("Til hamingju leikmaður, þú vannst!");
            }
            if ((btnTveir4.Text == btnTveir5.Text) && (btnTveir5.Text == btnTveir6.Text))
            {
                sigurvegari = true;
                MessageBox.Show("Til hamingju leikmaður, þú vannst!");
            }
            if ((btnTveir7.Text == btnTveir8.Text) && (btnTveir8.Text == btnTveir9.Text))
            {
                sigurvegari = true;
                MessageBox.Show("Til hamingju leikmaður, þú vannst!");
            }
            //lóðrétt
            if ((btnTveir11.Text == btnTveir4.Text) && (btnTveir4.Text == btnTveir7.Text))
            {
                sigurvegari = true;
                MessageBox.Show("Til hamingju leikmaður, þú vannst!");
            }
            if ((btnTveir2.Text == btnTveir5.Text) && (btnTveir5.Text == btnTveir8.Text))
            {
                sigurvegari = true;
                MessageBox.Show("Til hamingju leikmaður, þú vannst!");
            }
            if ((btnTveir3.Text == btnTveir6.Text) && (btnTveir6.Text == btnTveir9.Text))
            {
                sigurvegari = true;
                MessageBox.Show("Til hamingju leikmaður, þú vannst!");
            }
            //kross
            if ((btnTveir11.Text == btnTveir5.Text) && (btnTveir5.Text == btnTveir9.Text))
            {
                sigurvegari = true;
                MessageBox.Show("Til hamingju leikmaður, þú vannst!");
            }
            if ((btnTveir3.Text == btnTveir5.Text) && (btnTveir5.Text == btnTveir7.Text))
            {
                sigurvegari = true;
                MessageBox.Show("Til hamingju leikmaður, þú vannst!");
            }

            //MessageBox.Show("Til hamingju leikmaður, þú vannst!");
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
            
            

    }
}
