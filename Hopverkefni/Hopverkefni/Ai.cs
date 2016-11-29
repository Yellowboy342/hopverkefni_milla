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
    public partial class Ai : Form
    {

        bool lota = true;
        int stigx = 0, stigo = 0;
        int lotuteljari = 0;

        public Ai()
        {
            InitializeComponent();
        }

        private void btnAiClick(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (lota)
            {
                b.Text = "X";
                b.BackColor = System.Drawing.Color.Red;
            }

            else
            {
                b.Text = "O";
                b.BackColor = System.Drawing.Color.DarkGreen;
            }


            lota = !lota;
            b.Enabled = false;

            lotuteljari++;

            atugasigur();
        }
        private void atugasigur()
        {
            bool sigurvegari = false;
            //larétt
            if ((btnAi11.Text == btnAi2.Text) && (btnAi2.Text == btnAi3.Text) && (!btnAi11.Enabled))
                sigurvegari = true;
            else if ((btnAi4.Text == btnAi5.Text) && (btnAi5.Text == btnAi6.Text) && (!btnAi4.Enabled))
                sigurvegari = true;
            else if ((btnAi7.Text == btnAi8.Text) && (btnAi8.Text == btnAi9.Text) && (!btnAi7.Enabled))
                sigurvegari = true;
            //lóðrétt
            else if ((btnAi11.Text == btnAi4.Text) && (btnAi4.Text == btnAi7.Text) && (!btnAi11.Enabled))
                sigurvegari = true;
            else if ((btnAi2.Text == btnAi5.Text) && (btnAi5.Text == btnAi8.Text) && (!btnAi2.Enabled))
                sigurvegari = true;
            else if ((btnAi3.Text == btnAi6.Text) && (btnAi6.Text == btnAi9.Text) && (!btnAi3.Enabled))
                sigurvegari = true;
            //kross
            else if ((btnAi11.Text == btnAi5.Text) && (btnAi5.Text == btnAi9.Text) && (!btnAi11.Enabled))
                sigurvegari = true;
            else if ((btnAi3.Text == btnAi5.Text) && (btnAi5.Text == btnAi7.Text) && (!btnAi7.Enabled))
                sigurvegari = true;


            if (sigurvegari)
            {
                foreach (Control c in Controls)
                {

                }

                string vann = "";
                if (lota)
                {
                    vann = "O";
                    for (int i = 0; i < 1; i++)
                    {
                        stigo++;
                        label5.Text = stigo.ToString();
                        if (stigx == 10)
                        {
                            MessageBox.Show("O er sigurvergari leiksins", "O!!!!!!");
                            stigo = 0;
                            stigx = 0;
                        }
                    }
                    foreach (Control c in Controls)
                    {
                        try
                        {
                            lotuteljari = 0;
                            btnAi11.Text = "";
                            btnAi2.Text = "";
                            btnAi3.Text = "";
                            btnAi4.Text = "";
                            btnAi5.Text = "";
                            btnAi6.Text = "";
                            btnAi7.Text = "";
                            btnAi8.Text = "";
                            btnAi9.Text = "";
                            Button b = (Button)c;
                            b.Enabled = true;
                            b.BackColor = System.Drawing.Color.White;
                        }
                        catch { }
                    }
                }
                else
                {
                    vann = "X";
                    for (int i = 0; i < 1; i++)
                    {
                        stigx++;
                        label2.Text = stigx.ToString();
                        if (stigx == 10)
                        {
                            MessageBox.Show("X er sigurvergari leiksins", "X!!!!!!");
                            stigo = 0;
                            stigx = 0;
                        }
                    }

                    foreach (Control c in Controls)
                    {

                        try
                        {

                            lotuteljari = 0;
                            btnAi11.Text = "";
                            btnAi2.Text = "";
                            btnAi3.Text = "";
                            btnAi4.Text = "";
                            btnAi5.Text = "";
                            btnAi6.Text = "";
                            btnAi7.Text = "";
                            btnAi8.Text = "";
                            btnAi9.Text = "";
                            Button b = (Button)c;
                            b.Enabled = true;
                            b.BackColor = System.Drawing.Color.White;
                        }
                        catch { }
                    }
                }

                MessageBox.Show(vann + " vann þessa lotu");
                tbAi.Text = vann + " vann síðustu lotu";
            }
            else
            {
                if (lotuteljari == 9)
                {

                    tbAi.Text = ("Jafntefli");
                    foreach (Control c in Controls)
                    {
                        try
                        {
                            lotuteljari = 0;
                            btnAi11.Text = "";
                            btnAi2.Text = "";
                            btnAi3.Text = "";
                            btnAi4.Text = "";
                            btnAi5.Text = "";
                            btnAi6.Text = "";
                            btnAi7.Text = "";
                            btnAi8.Text = "";
                            btnAi9.Text = "";
                            Button b = (Button)c;
                            b.Enabled = true;
                            b.BackColor = System.Drawing.Color.White;
                        }
                        catch { }
                    }

                }
            }
        }
    }
}
