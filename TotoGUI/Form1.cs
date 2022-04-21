using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotoGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int h = textBox1.Text.Length;
            box_hossz.Text = $"Nem megfelelő a karakterek száma ({h})";
            if (h==14)
            {
                box_hossz.Checked = false;
            }
            else
            {
                box_hossz.Checked = true;
            }

            string boxos = textBox1.Text;
            //var rosszak = new List<char>();
            string rosszak = "";
            foreach (var item in boxos)
            {
                if (item == '1' || item == '2' || item == 'X')
                {
                    //rosszak.Add(item);
                //    box_rkarakter.Text = item.ToString();
                   
                }
                else
                {
                    rosszak += item+";";
                }
            }
            box_rkarakter.Text = $"Helytelen karakter az eredményekben ({rosszak.Trim(';')})";
            box_rkarakter.Checked = rosszak.Any();
            
            

 
        }
    }
}
