using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpArrayClassSeating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClassArray_Click(object sender, EventArgs e)
        {

            string[] names = { "Arthur", "Daniel", "Jane", "Darren", "Ethan", "Jeff", "Judah", "Kyle", "Sonya", "Josh", "Keum" };

            //using a For loop as we need the ccounter i
            for (var i = 0; i < names.Length; i++)
            { //get the name at that counter
                var name = names[i];

                //get the label at that number label1.text and then pass over the name
                this.Controls["label" + i.ToString()].Text = name;

                //  this.Controls["label" + i.ToString()].Width = name;

            }

            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    c.BackColor = Color.LightSteelBlue;
                    c.AutoSize = false;
                    c.Width = 70;
                    c.Height = 50;
                }
            }
        }
    }
}
