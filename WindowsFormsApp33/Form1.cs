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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel2.Enabled = true;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MonthCalendar a = new MonthCalendar();
            a.MinDate = DateTime.Now;
            a.TabIndex = 20;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            a.Location = new Point(60, 289);
            a.DateSelected += A_DateSelected;
            Controls.Add(a);
        }

        private void A_DateSelected(object sender, DateRangeEventArgs e)
        {
            comboBox3.Visible = true;
            comboBox4.Visible = true;
            comboBox5.Visible = true;

            Controls.Remove((MonthCalendar)sender);
        }


        private void panel2_Click(object sender, EventArgs e)
        {
            MonthCalendar a1 = new MonthCalendar();
            a1.MinDate = DateTime.Now;
            a1.TabIndex = 14;
            a1.TabIndex = 20;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            panel3.Visible = false;
            a1.Location = new Point(354, 289);
            a1.DateSelected += A_DateSelected1; ;
            Controls.Add(a1);
        }

        private void A_DateSelected1(object sender, DateRangeEventArgs e)
        {
            comboBox3.Visible = true;
            comboBox4.Visible = true;
            comboBox5.Visible = true;
            panel3.Visible = true;
            Controls.Remove((MonthCalendar)sender);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.ShowDialog();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
