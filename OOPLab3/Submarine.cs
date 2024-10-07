using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab3
{
    public partial class Submarine : UserControl
    {
        public Submarine()
        {
            InitializeComponent();
        }

        private uint vmax;
        private uint speed = 0;
        public bool Right;
        public bool Left;
        public bool Up;
        public bool Down;
        private ControlPanel controlPanel;

        public uint Vmax
        {
            get { return vmax; }
            set { vmax = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            controlPanel.submarine = this;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
