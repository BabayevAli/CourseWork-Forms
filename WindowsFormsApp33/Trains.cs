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
        List<string> names;
        List<int> placenum;
        public List<string> vaku = new List<string>();
        int count = 4;
        public Trains()
        {
            names = new List<string>();
            placenum = new List<int>();
            InitializeComponent();
        }

        
        PictureBox a;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            a = (PictureBox)sender;
            if (a.BackColor == Color.Lime && count != 0)
            {
                a.BackColor = Color.Gray;
                count--;
            }
            else if (a.BackColor == Color.Gray)
            {
                a.BackColor = Color.Lime;
                count++;
            }
            for (int i = 0; i < 7; i++)
            {
                if(a.Name == "pictureBox" + i.ToString())
                {
                    placenum.Add(i);
                    return;
                }
            }
        }

            ContextMenu cm = new ContextMenu();

        private void Trains_Load(object sender, EventArgs e)
        {
            foreach (var item in vaku)
            {
                cm.MenuItems.Add(item);
            }

            cm.MenuItems[0].Click += Trains_Click;
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
                names.Add(az.Text);
                cm.MenuItems.Remove(az);                
            }
        }
    }
}
