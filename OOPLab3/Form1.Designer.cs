namespace OOPLab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            controlPanel1 = new ControlPanel();
            submarine1 = new Submarine();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1235, 12);
            button1.Name = "button1";
            button1.Size = new Size(117, 94);
            button1.TabIndex = 1;
            button1.Text = "We live in a yellow submarine";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // controlPanel1
            // 
            controlPanel1.Location = new Point(825, 181);
            controlPanel1.Name = "controlPanel1";
            controlPanel1.Size = new Size(527, 421);
            controlPanel1.TabIndex = 0;
            controlPanel1.Load += controlPanel1_Load;
            // 
            // submarine1
            // 
            submarine1.Location = new Point(215, 282);
            submarine1.Name = "submarine1";
            submarine1.Size = new Size(346, 193);
            submarine1.Speed = 1U;
            submarine1.TabIndex = 2;
            submarine1.Vmax = 0U;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1364, 614);
            Controls.Add(submarine1);
            Controls.Add(button1);
            Controls.Add(controlPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private ControlPanel controlPanel1;
        private Submarine submarine1;
    }
}
