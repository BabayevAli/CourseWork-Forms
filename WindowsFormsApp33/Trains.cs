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
    public partial class Trains : Form
    {
        public Dictionary<string, sbyte> dic;
        public DialogResult dialogs = DialogResult.Cancel;
        public List<bool> pls;
        public Trains()
        {
            dic = new Dictionary<string, sbyte>();
            pls = new List<bool>();
            InitializeComponent();
        }

        public void LoadUsers(List<string> users)
        {
            dic.Clear();
            foreach (var item in users)
            {
                dic[item] = -1;
            }
        }


        PictureBox a;
        object sender_;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        ContextMenu cm = new ContextMenu();

        private void Trains_Load(object sender, EventArgs e)
        {
            foreach (var item in dic.Keys)
            {
                cm.MenuItems.Add(item).Click += Trains_Click;
            }
            if (pls[0])
                pictureBox1.ContextMenu = cm;
            else
                pictureBox1.BackColor = Color.Red;
            if (pls[1])
                pictureBox2.ContextMenu = cm;
            else
                pictureBox2.BackColor = Color.Red;
            if (pls[2])
                pictureBox3.ContextMenu = cm;
            else
                pictureBox3.BackColor = Color.Red;
            if (pls[3])
                pictureBox4.ContextMenu = cm;
            else
                pictureBox4.BackColor = Color.Red;
            if (pls[4])
                pictureBox5.ContextMenu = cm;
            else
                pictureBox5.BackColor = Color.Red;
            if (pls[5])
                pictureBox6.ContextMenu = cm;
            else
                pictureBox6.BackColor = Color.Red;
            if (pls[6])
                pictureBox7.ContextMenu = cm;
            else
                pictureBox7.BackColor = Color.Red;
            if (pls[7])
                pictureBox8.ContextMenu = cm;
            else
                pictureBox8.BackColor = Color.Red;
            if (pls[8])
                pictureBox9.ContextMenu = cm;
            else
                pictureBox9.BackColor = Color.Red;
        }

        private void Trains_Click(object sender, EventArgs e)
        {
            MenuItem az = (MenuItem)sender;
            a = (PictureBox)sender_;
            for (sbyte i = 1; i < 10; i++)
            {
                if (a.Name == "pictureBox" + i.ToString())
                {
                    dic[az.Text] = (sbyte)(i-1);
                    break;
                }
            }
            cm.MenuItems.Remove(az);
            a.ContextMenu = null;
            a.BackColor = Color.Gray;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                sender_ = sender;
            }
            else if (e.Button == MouseButtons.Left)
            {
                a = (PictureBox)sender;
                a.ContextMenu = cm;
                if (a.BackColor == Color.Gray)
                {
                    for (int i = 1; i < 10; i++)
                    {
                        if (a.Name == "pictureBox" + i.ToString())
                        {
                            string key = dic.FirstOrDefault(z => z.Value == i-1).Key;
                            dic[key] = -1;
                            cm.MenuItems.Add(key).Click += Trains_Click;
                            break;
                        }
                    }
                    a.BackColor = Color.Lime;
                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            foreach (var item in dic.Values)
            {
                if(item == -1)
                {
                    MessageBox.Show("Her hansisa bir userin yerini secmemisiniz!!");
                    return;
                }
            }
            Odeme odeme = new Odeme();
            Hide();
            odeme.ShowDialog();
            if (odeme.dialogs == DialogResult.OK)
            {
                dialogs = DialogResult.OK;
            }
            else
            {
                dialogs = DialogResult.Cancel;
                Show();
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            dialogs = DialogResult.Cancel;
            Hide();
        }
    }
}
