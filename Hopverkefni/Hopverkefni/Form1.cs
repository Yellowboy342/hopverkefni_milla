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
    public partial class btnNyrLekur : Form
    {
        bool lota  = true;
        int stigx = 0, stigo = 0;
        int lotuteljari = 0;
        public btnNyrLekur()
        {
            InitializeComponent();
        }
        private void btnTveir1(object sender, EventArgs e)
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
             if ((btnTveir11.Text == btnTveir2.Text) && (btnTveir2.Text == btnTveir3.Text) && (!btnTveir11.Enabled))
                sigurvegari = true;
             else if ((btnTveir4.Text == btnTveir5.Text) && (btnTveir5.Text == btnTveir6.Text) && (!btnTveir4.Enabled))
                sigurvegari = true;
             else if ((btnTveir7.Text == btnTveir8.Text) && (btnTveir8.Text == btnTveir9.Text) && (!btnTveir7.Enabled))
                sigurvegari = true;
            //lóðrétt
             else if ((btnTveir11.Text == btnTveir4.Text) && (btnTveir4.Text == btnTveir7.Text) && (!btnTveir11.Enabled))
                sigurvegari = true;
             else if ((btnTveir2.Text == btnTveir5.Text) && (btnTveir5.Text == btnTveir8.Text) && (!btnTveir2.Enabled))
                sigurvegari = true;
             else if ((btnTveir3.Text == btnTveir6.Text) && (btnTveir6.Text == btnTveir9.Text) && (!btnTveir3.Enabled))
                sigurvegari = true;
            //kross
             else if ((btnTveir11.Text == btnTveir5.Text) && (btnTveir5.Text == btnTveir9.Text) && (!btnTveir11.Enabled))
                sigurvegari = true;
             else if ((btnTveir3.Text == btnTveir5.Text) && (btnTveir5.Text == btnTveir7.Text) && (!btnTveir7.Enabled))
                sigurvegari = true;


            if(sigurvegari)
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
                            btnTveir11.Text = "";
                            btnTveir2.Text = "";
                            btnTveir3.Text = "";
                            btnTveir4.Text = "";
                            btnTveir5.Text = "";
                            btnTveir6.Text = "";
                            btnTveir7.Text = "";
                            btnTveir8.Text = "";
                            btnTveir9.Text = "";
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
                       if(stigx == 10)
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
                            btnTveir11.Text = "";
                            btnTveir2.Text = "";
                            btnTveir3.Text = "";
                            btnTveir4.Text = "";
                            btnTveir5.Text = "";
                            btnTveir6.Text = "";
                            btnTveir7.Text = "";
                            btnTveir8.Text = "";
                            btnTveir9.Text = "";
                            Button b = (Button)c;
                            b.Enabled = true;
                            b.BackColor = System.Drawing.Color.White;
                        }
                        catch { }      
                    }
                }

                MessageBox.Show(vann + " vann þessa lotu");
                tbSigur.Text = vann + " vann síðustu lotu";
            }
            else
            {
                if(lotuteljari == 9)
                {

                    tbSigur.Text = ("Jafntefli");
                    foreach (Control c in Controls)
                    {
                        try
                        {
                            lotuteljari = 0;
                            btnTveir11.Text = "";
                            btnTveir2.Text = "";
                            btnTveir3.Text = "";
                            btnTveir4.Text = "";
                            btnTveir5.Text = "";
                            btnTveir6.Text = "";
                            btnTveir7.Text = "";
                            btnTveir8.Text = "";
                            btnTveir9.Text = "";
                            Button b = (Button)c;
                            b.Enabled = true;
                            b.BackColor = System.Drawing.Color.White;
                        }
                        catch { }
                    } 

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void spilaAfturToolStripMenuItem_Click(object sender, EventArgs e)
        {
                     
        }

        private void nýrLeikurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();        
        }

        private void btnNyrLekur_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
            
            

    }
}
