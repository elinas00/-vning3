using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeColor(object sender, EventArgs e)
        {
            Button b = sender as Button;

            DialogResult c = dlgColor.ShowDialog();
            if (c == DialogResult.OK)
            {
                if(b is Button)
                {
                     b.BackColor = dlgColor.Color;
                }
                else
                {
                    this.BackColor = dlgColor.Color;
                }
            }

        }

        private void changeFolder(object sender, EventArgs e)
        {
            Button b = sender as Button;

            DialogResult p = dlgFolder.ShowDialog();
            if(p == DialogResult.OK)
            {
                b.Text = dlgFolder.SelectedPath;
            }

        }

        private void changeFont(object sender, EventArgs e)
        {
            Button b = sender as Button;
            ContextMenuStrip m = sender as ContextMenuStrip;

            DialogResult f = dlgFont.ShowDialog();
            if(f == DialogResult.OK)
            {
                if(b is Button)
                {
                    b.Font = dlgFont.Font;
                }
                else
                {
                    this.Font = dlgFont.Font;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
