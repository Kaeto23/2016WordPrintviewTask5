using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2016WordPrintviewTask5
{
    public partial class UserControl1 : UserControl
    {
        public event EventHandler<string> PrinterSelected;
        private List<string> printers = new List<string>
    {
        "Fax",
        "HPFBDE53 (HP DeskJet 3630 Series)",
        "HPFBDE53 (HP DeskJet 3630 Series) (Copy)",
        "Microsoft Print PDF",
        "Microsoft XPS Document Writer",
        "Nitro PDF Creator",
        "OneNote (Desktop)",
        "Send to OneNote 2013",
        };
       


        public UserControl1()
        {
            InitializeComponent();
            NewMethod();

            void NewMethod()
            {
                btnPrinter.Click += btnPrinter_Click;
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void ShowPrinterDropdown()
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

            foreach (var printer in printers)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(printer);
                item.Click += (s, e) => OnPrinterSelected(printer);
                contextMenuStrip.Items.Add(item);
            }

            contextMenuStrip.Show(btnPrinter, new System.Drawing.Point(0, btnPrinter.Height));
        }

        private void OnPrinterSelected(string printer)
        {
            PrinterSelected?.Invoke(this, printer);
        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            ShowPrinterDropdown();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}