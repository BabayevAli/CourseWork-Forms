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
    public partial class ListTrains : Form
    {
        public int big, med, low;
        public string gel, get, qatar;
        public DateTime time;

        private void panel1_Click(object sender, EventArgs e)
        {
            Form2 trains = new Form2();
            trains.big = big;
            trains.med = med;
            trains.low = low;
            trains.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public ListTrains()
        {
            InitializeComponent();
        }

        private void ListTrains_Load(object sender, EventArgs e)
        {
            label14.Text = gel;
            label15.Text = get;
            label16.Text = time.ToShortDateString();
            label20.Text = gel + " - " + get + "(" + time.ToShortDateString() + ")";
            label14.Location = new Point(1211, 130);
            label15.Location = new Point(1221, 145);
            label16.Location = new Point(1187, 160);
            panel1.Location = new Point(549, 168);
            panel1.Size = new Size(271, 194);
            label20.Location = new Point(136, 24);
            label1.Location = new Point(1124, 177);
            //label2.Location = new Point(124, 23);
        }
    }
}
