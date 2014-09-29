using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListViewPractice
{
    public partial class ListviewUI : Form
    {
        public ListviewUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(textBox1.Text);
            lvi.SubItems.Add(textBox2.Text);
            lvi.SubItems.Add(textBox3.Text);

            listView1.Items.Add(lvi);
            

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }


        }
    }
}
