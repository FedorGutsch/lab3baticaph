using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private uint vmax = 300;
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
            set { speed = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            controlPanel.submarine = this;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Up)
            {
                if (speed < vmax)
                {
                    speed++;
                }
                if (this.Top > -100)
                {
                    this.Top -= 1 * (int)speed;
                }
            }
            else if (Down)
            {
                if (speed < vmax)
                {
                    speed++;
                }
                if (this.Bottom < 615)
                {
                    this.Top += 1 * (int)speed;
                }
            }
            else if (Lefti)
            {
                if (speed < vmax)
                {
                    speed++;
                }
                this.Left += 1 * (int)speed;
            }
            else if (Right)
            {
                if (speed < vmax)
                {
                    speed++;
                }
                this.Left -= 1 * (int)speed;
            }
            else if (!Up && !Down && !Lefti && !Right)
            {
                speed = 1;
            }
        }
    }
}
