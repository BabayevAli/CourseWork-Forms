using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp33
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

       
        public MonthCalendar a = new MonthCalendar();

        private void panel1_Click(object sender, EventArgs e)
        {
            a.Location = new Point(69, 80);
            comboBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox1.Visible = false;
            a.DateSelected += A_DateSelected;
            
            Controls.Add(a);
        }

        private void A_DateSelected(object sender, DateRangeEventArgs e)
        {
            comboBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox1.Visible = true;
            label2.Text = a.SelectionRange.Start.ToShortDateString();
            label2.ForeColor = Color.FromArgb(0, 123, 200);
            Controls.Remove((MonthCalendar)sender);
            label2.Text = a.SelectionRange.Start.ToShortDateString();

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Ad")
            {
                textBox1.Clear();
                textBox1.ForeColor = Color.FromArgb(0, 123, 200);
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "Soyad")
            {
                textBox2.Clear();
                textBox2.ForeColor = Color.FromArgb(0, 123, 200);
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "SENEDIN SERIYA VE YA NOMRESI")
            {
                textBox3.Clear();
                textBox3.ForeColor = Color.FromArgb(0, 123, 200);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Ad";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                textBox2.Text = "Soyad";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "SENEDIN SERIYA VE YA NOMRESI";
                textBox3.ForeColor = Color.Gray;
            }
        }
    }
}
