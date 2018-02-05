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
    public partial class Odeme : Form
    {
        int count = 150;
        public DialogResult dialogs = DialogResult.Cancel;
        public Odeme()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tex = (TextBox)sender;
            if(tex.Text.Length == 0)
            {
                return;
            }
            for (int i = 0; i < tex.Text.Length; i++) { 
                if(tex.Text[i] >= 'a' && tex.Text[i] <= 'z' || tex.Text[i] >= 'A' && tex.Text[i] <= 'Z')
                {
                    tex.Text = tex.Text.Remove(i,1);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            label1.Text = count / 60 + "   " + count % 60;
            if (count == 0)
            {
                timer1.Stop();
                MessageBox.Show("Odeme vaxti bitdi!!!");
                Hide();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox tex = (TextBox)sender;
            if (tex.Text.Length == 0)
            {
                return;
            }
            for (int i = 0; i < tex.Text.Length; i++)
            {
                if (tex.Text[i] >= 'a' && tex.Text[i] <= 'z' || tex.Text[i] >= 'A' && tex.Text[i] <= 'Z')
                {
                    tex.Text = tex.Text.Remove(i, 1);
                }
            }
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            label2.Text = new Random().Next(6, 19).ToString() +"."+ (new Random().Next(10, 100)).ToString();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length != 8||textBox1.Text == ""||comboBox3.SelectedIndex<0||comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex<0 || textBox2.Text == "" || textBox2.Text.Length != 3)
            {
                return;
            }
            dialogs = DialogResult.OK;
            Hide();
        }
    }
}
