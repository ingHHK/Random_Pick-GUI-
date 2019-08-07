using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public int picking_number;

        int[] check_Category = new int[4] { 0,0,0,0 };
        int[] selected_Number = new int[10];
        int[] selected_Number1 = new int[10];
        int[] selected_Number2 = new int[10];
        int[] selected_Number3 = new int[10];
        int[] selected_Number4 = new int[10];

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            check_Category[0] = 3;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            check_Category[1] = 2;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            check_Category[2] = 1;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            check_Category[3] = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.picking_number = Convert.ToInt32(this.word_Number.Text);
            DisaplyWords display = new DisaplyWords(ref check_Category, picking_number);
            display.Displaying_Words();
            display.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
