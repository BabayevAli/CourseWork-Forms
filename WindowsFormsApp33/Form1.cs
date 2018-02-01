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
        bool checkdate = false;
        MonthCalendar a = null;
        List<string> list = new List<string>();
        MonthCalendar f;

        public Form1()
        {
            InitializeComponent();
            panel2.Enabled = true;
            list.Add("ASTARA");
            list.Add("BAKI - SƏRN");
            list.Add("BAŞ ƏLƏT");
            list.Add("BİLƏCƏRİ");
            list.Add("CƏLİLABAD");
            list.Add("DAYKƏND");
            list.Add("KEŞLƏ");
            list.Add("LƏNKƏRAN");
            list.Add("LİMAN");
            list.Add("LÖKBATAN");
            list.Add("MASALLI");
            list.Add("OSMANLI");
            list.Add("PL. 111 KM");
            list.Add("QAMIŞLIQ");
            list.Add("QARADAĞ");
            list.Add("QASIMLI");
            list.Add("QIRMIZIKƏND");
            list.Add("SALYAN");
            list.Add("ŞİRVAN - ÇEŞİD.");
            list.Add("ŞİRVAN - SƏRN.");
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            a = new MonthCalendar();
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
            f = (MonthCalendar)sender;
            label1.Text = f.SelectionRange.Start.ToShortDateString();
            Controls.Remove((MonthCalendar)sender);
            checkdate = true;
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
            MonthCalendar f = (MonthCalendar)sender;
            label2.Text = f.SelectionRange.Start.ToShortDateString();
            Controls.Remove((MonthCalendar)sender);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex <0 || Int32.Parse(comboBox3.SelectedItem.ToString()) +
                                               Int32.Parse(comboBox4.SelectedItem.ToString()) + 
                                               Int32.Parse(comboBox5.SelectedItem.ToString()) == 0)
            {
                return;
            }
            else if (comboBox2.SelectedIndex < 0)
            {
                return;
            }
            else if(checkdate == false)
            {
                return;
            }
            else if (checkBox1.Checked == false)
            {
                return;
            }
            ListTrains train = new ListTrains();
            train.time = f.SelectionRange.Start;
            train.gel = comboBox1.SelectedItem.ToString();
            train.get = comboBox2.SelectedItem.ToString();
            train.big = Int32.Parse(comboBox3.SelectedItem.ToString());
            train.med = Int32.Parse(comboBox4.SelectedItem.ToString());
            train.low = Int32.Parse(comboBox5.SelectedItem.ToString());

            train.Size = new Size(1418, 627);
            train.ShowDialog();
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
            radioButton1.Checked = true;
            panel2.Enabled = false;
            comboBox3.SelectedItem = "0";comboBox4.SelectedItem = "0";comboBox5.SelectedItem = "0";
            
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            var az = comboBox1.SelectedItem;
            comboBox1.SelectedItem = comboBox2.SelectedItem;
            comboBox2.SelectedItem = az;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedItem != null && comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == comboBox2.SelectedItem.ToString())
                {
                    MessageBox.Show("Eyni yeri secmek olmaz!!");
                    comboBox1.SelectedItem = -1;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                if (comboBox2.SelectedItem.ToString() == comboBox1.SelectedItem.ToString())
                {
                    MessageBox.Show("Eyni yeri secmek olmaz!!");
                    comboBox2.SelectedIndex = -1;
                }
            }
        }
    }

    public class User
    {
        public string Name, Surname, SeriaNum, Country, Cinsi;
        public DateTime Birth;
        public User(string n , string s , string i , string c , string sex)
        {
            Name = n;
            Surname = s;
            SeriaNum = i;
            Country = c;
            Cinsi = sex;

        }
    }

    //public class VaqonMini
    //{
    //    public Dictionary<byte, User> places;
    //    public VaqonMini()
    //    {
    //        places = new Dictionary<byte, User>();
    //    }
    //}
    //
    //public class VaqonNormal
    //{
    //    public Dictionary<byte, User> places;
    //    public VaqonNormal()
    //    {
    //        places = new Dictionary<byte, User>();
    //    }
    //}

    public class VaqonBig
    {
        public Dictionary<byte, User> places;
        public VaqonBig()
        {
            places = new Dictionary<byte, User>();
        }
    }

    public class Qatar
    {
        public VaqonBig big;

        public Qatar()
        {
            big = new VaqonBig();
        }
    }

    public class ListQatar
    {
        public Dictionary<DateTime,Qatar> qatars;

        public ListQatar()
        {
            qatars = new Dictionary<DateTime, Qatar>();
        }

    }
    
}
