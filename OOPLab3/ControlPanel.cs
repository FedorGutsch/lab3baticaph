using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOPLab3
{
    public partial class ControlPanel : UserControl
    {
        public ControlPanel()
        {
            InitializeComponent();
            submarine = new Submarine();
        }

        public Submarine submarine;

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            //label1.DataBindings.Add("Text", this.submarine, "Speed");
            //label2.DataBindings.Add("Text", this.submarine, "Deep");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            submarine.Up = true;
            button1.BackColor = Color.Yellow;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            submarine.Up = false;
            button1.BackColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            submarine.Up = false;
            button1.BackColor = Color.Blue;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            submarine.Lefti = true;
            button2.BackColor = Color.Yellow;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            submarine.Lefti = false;
            button2.BackColor = Color.Blue;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            submarine.Lefti = false;
            button2.BackColor = Color.Blue;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            submarine.Right = true;
            button3.BackColor = Color.Yellow;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            submarine.Right = false;
            button3.BackColor = Color.Blue;
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            submarine.Right = false;
            button3.BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            submarine.Down = true;
            button4.BackColor = Color.Yellow;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            submarine.Down = false;
            button4.BackColor = Color.Blue;
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            submarine.Down = false;
            button4.BackColor = Color.Blue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            submarine.Vmax += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            submarine.Vmax -= 5;
        }
    }
}
