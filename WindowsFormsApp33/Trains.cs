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

        public List<string> vaku = new List<string>();
        int count = 4;
        public Trains()
        {
            InitializeComponent();
        }

        
        PictureBox a;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
                a = (PictureBox)sender;
                if (pictureBox1.BackColor == Color.Lime && count!= 0)
                {
                    pictureBox1.BackColor = Color.Gray;
                    count--;
                }
                else if (a.BackColor == Color.Gray)
                {
                    pictureBox1.BackColor = Color.Lime;
                    count++;
                }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
                a = (PictureBox)sender;

            if (pictureBox2.BackColor == Color.Lime && count!= 0)
                {
                    pictureBox2.BackColor = Color.Gray;
                    count--;
                }
                else if(a.BackColor == Color.Gray)
                {
                    pictureBox2.BackColor = Color.Lime;
                    count++;
                }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
                a = (PictureBox)sender;

            if (pictureBox3.BackColor == Color.Lime && count!= 0)
                {
                    pictureBox3.BackColor = Color.Gray;
                    count--;
                }
                else if(a.BackColor == Color.Gray)
                {
                    pictureBox3.BackColor = Color.Lime;
                    count++;
                }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
                a = (PictureBox)sender;

            if (pictureBox4.BackColor == Color.Lime && count!= 0)
                {
                    pictureBox4.BackColor = Color.Gray;
                    count--;
                }
                else if(a.BackColor == Color.Gray)
                {
                    pictureBox4.BackColor = Color.Lime;
                    count++;
                }
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
                a = (PictureBox)sender;

            if (pictureBox5.BackColor == Color.Lime && count!= 0)
                {
                    pictureBox5.BackColor = Color.Gray;
                    count--;
                }
                else if(a.BackColor == Color.Gray)
                {
                    pictureBox5.BackColor = Color.Lime;
                    count++;
                }
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
                a = (PictureBox)sender;

            if (pictureBox6.BackColor == Color.Lime && count!= 0)
                {
                    pictureBox6.BackColor = Color.Gray;
                    count--;
                }
                else if(a.BackColor == Color.Gray)
                {
                    pictureBox6.BackColor = Color.Lime;
                    count++;
                }
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
                a = (PictureBox)sender;

            if (pictureBox7.BackColor == Color.Lime && count!= 0)
                {
                    pictureBox7.BackColor = Color.Gray;
                    count--;
                }
                else if(a.BackColor == Color.Gray)
                {
                    pictureBox7.BackColor = Color.Lime;
                    count++;
                }
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
                a = (PictureBox)sender;

            if (pictureBox8.BackColor == Color.Lime && count!= 0)
                {
                    pictureBox8.BackColor = Color.Gray;
                    count--;
                }
                else if(a.BackColor == Color.Gray)
                {
                    pictureBox8.BackColor = Color.Lime;
                    count++;
                }
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
                a = (PictureBox)sender;

            if (pictureBox9.BackColor == Color.Lime && count!= 0)
                {
                    pictureBox9.BackColor = Color.Gray;
                    count--;
                }
                else if(a.BackColor == Color.Gray)
                {
                    pictureBox9.BackColor = Color.Lime;
                    count++;
               }
            
        }

        private void Trains_Load(object sender, EventArgs e)
        {
            ContextMenu cm = new ContextMenu();
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
            throw new NotImplementedException();
        }
    }
}
