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
        public Trains()
        {
            dic = new Dictionary<string, sbyte>();
            InitializeComponent();
        }

        public void LoadUsers(List<string> users)
        {
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
            pictureBox1.ContextMenu = cm;
            pictureBox2.ContextMenu = cm;
            pictureBox3.ContextMenu = cm;
            pictureBox4.ContextMenu = cm;
            pictureBox5.ContextMenu = cm;
            pictureBox6.ContextMenu = cm;
            pictureBox7.ContextMenu = cm;
            pictureBox8.ContextMenu = cm;
            pictureBox9.ContextMenu = cm;
        }

        private void Trains_Click(object sender, EventArgs e)
        {
            MenuItem az = (MenuItem)sender;
            a = (PictureBox)sender_;
            for (sbyte i = 0; i < 7; i++)
            {
                if (a.Name == "pictureBox" + i.ToString())
                {
                    dic[az.Text] = i;
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
                    for (int i = 0; i < 7; i++)
                    {
                        if (a.Name == "pictureBox" + i.ToString())
                        {
                            string key = dic.FirstOrDefault(z => z.Value == i).Key;
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
            dialogs = DialogResult.OK;
            Hide();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            dialogs = DialogResult.Cancel;
            Hide();
        }
    }
}
