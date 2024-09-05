using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2016WordPrintviewTask5
{
    public partial class PrinterNew : Form
    {
        public PrinterNew()
        {
            InitializeComponent();
       

        }

        bool timer = false;



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer == false)
            {
                panelDropdown.Height += 15;
                if (panelDropdown.Height >= panelDropdown.MaximumSize.Height)
                {
                    timer1.Stop();
                    timer = true;

                }    
            }

            else 
            { 
                panelDropdown.Height -= 15;
                if (panelDropdown.Height <= panelDropdown.MinimumSize.Height)
                {
                        timer1.Stop();
                        timer = false;
                }
            }
           
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button11.Text = "HPFBDE53 (HP DeskJet 3630 Series)";
            label28.Text = "Offline";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button11.Text = "HPFBDE53 (HP DeskJet 3630 Series) (Copy1)";
            label28.Text = "Offline";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button11.Text = "Microsoft Print PDF";
            label28.Text = "Ready";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button11.Text = "Microsoft XPS Document Writer";
            label28.Text = "Ready";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button11.Text = "Nitro PDF Creator";
            label28.Text = "Ready";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button11.Text = "Fax";
            label28.Text = "Ready";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button11.Text = "OneNote (Desktop)";
            label28.Text = "Ready";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button11.Text = "Send to OneNote 2013";
            label28.Text = "Ready";
        }

        private void PrinterNew_Load(object sender, EventArgs e)
        {

        }
    }
}
