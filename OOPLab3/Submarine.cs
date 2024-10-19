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
        public Submarine()
        {
            InitializeComponent();
        }

        private uint vmax = 10;
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
            get { return this.Top; }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //controlPanel.label1.DataBindings.Clear();
            //controlPanel.label2.DataBindings.Clear();
            //controlPanel.submarine = this;
            //controlPanel.label1.DataBindings.Add("Text", controlPanel.submarine, "Speed");
            //controlPanel.label2.DataBindings.Add("Text", controlPanel.submarine, "Deep");
        }

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
                    this.Top -= 1 * (int)Speed;
                }
            }
            else if (Down)
            {
                if (speed < vmax)
                {
                    Speed++;
                }
                if (this.Bottom < 615)
                {
                    this.Top += 1 * (int)Speed;
                }
            }
            else if (Lefti)
            {
                if (speed < vmax)
                {
                    Speed++;
                }
                this.Left += 1 * (int)Speed;
            }
            else if (Right)
            {
                if (speed < vmax)
                {
                    Speed++;
                }
                this.Left -= 1 * (int)Speed;
            }
            else if (!Up && !Down && !Lefti && !Right)
            {
                speed = 0;
                Speed = 0;
            }
        }

        private void Submarine_Click(object sender, EventArgs e)
        {
            controlPanel.label1.DataBindings.Clear();
            controlPanel.label2.DataBindings.Clear();
            controlPanel.submarine = this;
            controlPanel.label1.DataBindings.Add("Text", controlPanel.submarine, "Speed");
            controlPanel.label2.DataBindings.Add("Text", controlPanel.submarine, "Deep");
        }
    }
}
