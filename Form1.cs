using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2016WordPrintviewTask5
{
    public partial class Form1 : Form
    {
        bool timer = false;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

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

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button27.Text = "HPFBDE53 (HP DeskJet 3630 Series)";
            label43.Text = "Offline";
        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            button27.Text = "HPFBDE53 (HP DeskJet 3630 Series) (Copy1)";
            label43.Text = "Offline";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button27.Text = "Microsoft Print PDF";
            label43.Text = "Ready";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button27.Text = "Microsoft XPS Document Writer";
            label43.Text = "Ready";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button27.Text = "Nitro PDF Creator";
            label43.Text = "Ready";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button27.Text = "Fax";
            label43.Text = "Ready";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button27.Text = "OneNote (Desktop)";
            label43.Text = "Ready";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button27.Text = "Send to OneNote 2013";
            label43.Text = "Ready";
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel4.AutoScroll = false;
            //panel4.VerticalScroll.Value = vScrollBar1.Value;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer == false)
            {
                panelDropdown2.Height += 15;
                if (panelDropdown2.Height >= panelDropdown2.MaximumSize.Height)
                {
                    timer2.Stop();
                    timer = true;

                }
            }

            else
            {
                panelDropdown2.Height -= 15;
                if (panelDropdown2.Height <= panelDropdown2.MinimumSize.Height)
                {
                    timer2.Stop();
                    timer = false;
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button35.Text = "Print All Pages";
            label49.Text = "The whole thing";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button35.Text = "Print Current Pages";
            label49.Text = "Just this page";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button35.Text = "Custom Print";
            label49.Text = "Type specic ranges,section and pages.";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button35.Text = "Document Info";
            label49.Text = "List of properties,e.g file,author and title";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button35.Text = "List of Markup";
            label49.Text = "Your tracked changes";
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            button35.Text = "Styles";
            label49.Text = "List of styles used in your document ";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button35.Text = "Autotext Entities";
            label49.Text = "List of items in your autotext gallery";
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
