namespace OOPLab3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            submarine1.controlPanel = controlPanel1;
            controlPanel1.submarine = submarine1;
            submarine1.Vmax = 300;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void controlPanel1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Submarine submarine = new Submarine();
            submarine.Vmax = 300;
            submarine.controlPanel = controlPanel1;
            Controls.Add(submarine);
        }
    }
}
