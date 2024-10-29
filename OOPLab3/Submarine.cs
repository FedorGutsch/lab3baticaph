using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab3
{
    public partial class Submarine : UserControl, INotifyPropertyChanged
    {
        public Submarine(ControlPanel ControlPanel)
        {
            InitializeComponent();
            controlPanel = ControlPanel;
        }

        private uint vmax = 3;
        private uint speed = 1;
        private int deep;
        public bool Right;
        public bool Lefti;
        public bool Up;
        public bool Down;
        public ControlPanel controlPanel;

        public uint Vmax
        {
            get { return vmax; }
            set { vmax = value; OnPropertyChanged(); }
        }

        public int Deep
        {
            get { return deep; }
            set { deep = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public uint Speed
        {
            get { return speed; }
            set { speed = value; OnPropertyChanged(); }
        }

        bool lastIsUp = false;
        bool lastIsDown = false;
        bool lastIsRight = false;
        bool lastIsLeft = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Up)
            {
                if (speed < vmax)
                {
                    Speed++;
                }
                if (this.Top > -100)
                {
                    lastIsUp = true;
                    lastIsDown = false;
                    lastIsLeft = false;
                    lastIsRight = false;
                    this.Top -= 1 * (int)Speed;
                    Deep = this.Top;
                }
            }
            else if (Down)
            {
                if (speed < vmax)
                {
                    Speed++;
                }
                if (this.Bottom < this.ParentForm.Height)
                {
                    lastIsUp = false;
                    lastIsDown = true;
                    lastIsLeft = false;
                    lastIsRight = false;
                    this.Top += 1 * (int)Speed;
                    Deep = this.Top;
                }
            }
            else if (Lefti)
            {
                if (speed < vmax)
                {
                    Speed++;
                }
                if (this.Left > 0)
                {
                    lastIsUp = false;
                    lastIsDown = false;
                    lastIsLeft = true;
                    lastIsRight = false;
                    this.Left -= 1 * (int)Speed;
                }
            }
            else if (Right)
            {
                if (speed < vmax)
                {
                    Speed++;
                }
                if (this.Left < this.ParentForm.Width - this.Width)
                {
                    lastIsUp = false;
                    lastIsDown = false;
                    lastIsLeft = false;
                    lastIsRight = true;
                    this.Left += 1 * (int)Speed;
                }
            }
            else if (!Up && !Down && !Lefti && !Right)
            {
                if (lastIsUp == true)
                {
                    if (this.Top > -100)
                    {
                        this.Top -= 1 * (int)Speed;
                        Deep = this.Top;
                    }
                }
                else if (lastIsDown == true)
                {
                    if (this.Bottom < this.ParentForm.Height)
                    {
                        this.Top += 1 * (int)Speed;
                        Deep = this.Top;
                    }
                }
                else if (lastIsLeft == true)
                {
                    if (this.Left > 0)
                    {
                        this.Left -= 1 * (int)Speed;
                    }
                }
                else if (lastIsRight == true)
                {
                    if (this.Left < this.ParentForm.Width - this.Width)
                    {
                        this.Left += 1 * (int)Speed;
                    }
                }
            }
        }

        private void Submarine_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            controlPanel.label1.DataBindings.Clear();
            controlPanel.label2.DataBindings.Clear();
            controlPanel.submarine = this;
            controlPanel.label1.DataBindings.Add("Text", this, "Speed");
            controlPanel.label2.DataBindings.Add("Text", this, "Deep");
        }
    }
}
