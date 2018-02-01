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
        public int big, med, low;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < big + med + low; i++)
            {
                tableLayoutPanel1.Controls.Add(new UserControl1());
            }
            if (big + med + low < 3)
            {
                tableLayoutPanel1.RowCount--;
                tableLayoutPanel1.Size = new Size(tableLayoutPanel1.Size.Width, 310);
                this.Size = new Size(tableLayoutPanel1.Size.Width, 310);
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
            a.LoadUsers(va);
            a.ShowDialog();
            if (a.dialogs == DialogResult.OK)
            {
                Dictionary<string, int> placesinfo = a.dic;
                foreach (var item in placesinfo.Values)
                {
                    MessageBox.Show(item.ToString());
                }
                Hide();
            }
            else
            {
                MessageBox.Show("He used back!!1");
            }
        }
    }
}
