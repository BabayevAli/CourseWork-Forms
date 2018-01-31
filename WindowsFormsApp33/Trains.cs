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
        public Dictionary<string, int> dic;
        public List<string> vaku = new List<string>();
        int count = 4;
        public Trains()
        {
            dic = new Dictionary<string, int>();
            InitializeComponent();
        }

        public void LoadUsers(List<string>users)
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
            foreach (var item in vaku)
            {
                cm.MenuItems.Add(item);
            }

            cm.MenuItems[0].Click += Trains_Click;
            cm.MenuItems[1].Click += Trains_Click;
            cm.MenuItems[2].Click += Trains_Click;
            cm.MenuItems[3].Click += Trains_Click;
            pictureBox1.ContextMenu = cm;
            pictureBox2.ContextMenu = cm;
            pictureBox3.ContextMenu = cm;
            pictureBox4.ContextMenu = cm;
            pictureBox5.ContextMenu = cm;
            pictureBox6.ContextMenu = cm;
            pictureBox7.ContextMenu = cm;
            
        }

        private void Trains_Click(object sender, EventArgs e)
        {
            MenuItem az = sender as MenuItem;
            if (az != null)
            {
                a = (PictureBox)sender_;
                for (int i = 0; i < 7; i++)
                {
                    if (a.Name == "pictureBox" + i.ToString())
                    {
                        dic[az.Text] = i;
                        break;
                    }
                }
                cm.MenuItems.Remove(az);
                a.BackColor = Color.Gray;
                count--;
            }
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                sender_ = sender;
            }
            else if(e.Button == MouseButtons.Left)
            {
                a = (PictureBox)sender;
                if (a.BackColor == Color.Gray)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (a.Name == "pictureBox" + i.ToString())
                        {
                            string key = dic.FirstOrDefault(z => z.Value == i).Key;
                            dic[key] = -1;
                            cm.MenuItems.Add(key);
                            break;
                        }
                    }
                    a.BackColor = Color.Lime;
                    count++;
                }
            }
        }
    }
}
