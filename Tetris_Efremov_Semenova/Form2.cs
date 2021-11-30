using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris_Efremov_Semenova
{

    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            Form1 form1 = new Form1();
        }

        public string Txt
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Close();
        }
    }
}
