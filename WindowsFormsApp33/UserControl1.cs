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

        MonthCalendar a = new MonthCalendar();

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
            label1.Text = a.SelectionRange.Start.ToShortDateString();
            Controls.Remove((MonthCalendar)sender);
        }
    }
}
