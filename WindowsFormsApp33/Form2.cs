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
        public List<UserControl1> bigs;
        public List<UserControl1> mids;
        public List<User> users;
        public DialogResult dialogs = DialogResult.Cancel;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            bigs = new List<UserControl1>();
            mids = new List<UserControl1>();
            for (int i = 0; i < big; i++)
            {
                UserControl1 other = new UserControl1();
                other.label3.Text = "BOYUK (Sernisin " + (i + 1).ToString() + ")";
                bigs.Add(other); 
                tableLayoutPanel1.Controls.Add(other);
            }
            for (int i = 0; i < med; i++)
            {
                UserControl1 other = new UserControl1();
                other.label3.Text = "USAQ (Sernisin " + (i+1).ToString() + ")";
                mids.Add(other);
                tableLayoutPanel1.Controls.Add(other);
            }
            if (big + med < 3)
            {
                tableLayoutPanel1.RowCount--;
                tableLayoutPanel1.Size = new Size(tableLayoutPanel1.Size.Width, 310);
                this.Size = new Size(tableLayoutPanel1.Size.Width, 310);
            }
            users = new List<User>();
        }
        public void LoadUsersSave()
        {
            foreach (var item in bigs)
            {
                users.Add(new User(item.textBox1.Text, item.textBox2.Text, item.textBox3.Text, item.comboBox1.SelectedItem.ToString(), item.groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text, item.a.SelectionStart));
            }
            foreach (var item in mids)
            {
                users.Add(new User(item.textBox1.Text, item.textBox2.Text, item.textBox3.Text, item.comboBox1.SelectedItem.ToString(), item.groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text, item.a.SelectionStart));
            }
            foreach (var item in users)
            {
                MessageBox.Show(item.ToString());
            }
        }
        public Trains a = new Trains();

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            foreach (var item in bigs)
            {
                if(item.textBox1.Text == "" || item.textBox1.Text == "Ad" || item.textBox2.Text == "Soyad" || item.textBox2.Text == "" || item.textBox3.Text == "SENEDIN SERIYA VE YA NOMRESI" || item.textBox3.Text == "" || item.comboBox1.SelectedIndex < 0|| item.groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text == ""|| item.a.SelectionStart == null)
                {
                    MessageBox.Show("Duzgun Doldurun!!");
                    return;
                }
            }
            foreach (var item in mids)
            {
                if (item.textBox1.Text == "" || item.textBox1.Text == "Ad" || item.textBox2.Text == "Soyad" || item.textBox2.Text == "" || item.textBox3.Text == "SENEDIN SERIYA VE YA NOMRESI" || item.textBox3.Text == "" || item.comboBox1.SelectedIndex < 0 || item.groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text == "" || item.a.SelectionStart == null)
                {
                    MessageBox.Show("Duzgun Doldurun!!");
                    return;
                }
            }
            List<string> va = new List<string>();
            foreach (var item in bigs)
            {
                va.Add(item.textBox1.Text);
            }
            foreach (var item in mids)
            {
                va.Add(item.textBox1.Text);
            }
            LoadUsersSave();
            a.LoadUsers(va);
            Hide();
            a.ShowDialog();
            if (a.dialogs == DialogResult.OK)
            {
                a.DialogResult = DialogResult.OK;
            }
            else
            {
                Show();
            }
        }
    }
}
