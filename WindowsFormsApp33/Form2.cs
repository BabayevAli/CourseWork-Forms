using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp33
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Add(new UserControl1());
            tableLayoutPanel1.RowCount--;
            tableLayoutPanel1.Size = new Size(tableLayoutPanel1.Size.Width,310);
            this.Size = new Size(tableLayoutPanel1.Size.Width, 310);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                MessageBox.Show("SSSs");
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Trains a = new Trains();
            List<string> va = new List<string>();
            va.Add("Ali");
            va.Add("Murad");
            va.Add("Fazil");
            va.Add("Orxan");
            a.vaku = va;
            a.ShowDialog();
        }
    }
}
