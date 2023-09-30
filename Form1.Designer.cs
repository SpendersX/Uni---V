namespace UniV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 400);
            button1.Name = "button1";
            button1.Size = new Size(736, 48);
            button1.TabIndex = 0;
            button1.Text = "Inject";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkGray;
            textBox1.Location = new Point(12, 360);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(607, 34);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(625, 360);
            button2.Name = "button2";
            button2.Size = new Size(123, 34);
            button2.TabIndex = 2;
            button2.Text = "Sellect DLl";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(59, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 94);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 39);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 4;
            label1.Text = "No Dlls Injected";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 40, 40);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(-57, -8);
            panel2.Name = "panel2";
            panel2.Size = new Size(954, 101);
            panel2.TabIndex = 5;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGray;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(682, 31);
            button4.Name = "button4";
            button4.Size = new Size(51, 45);
            button4.TabIndex = 7;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(754, 31);
            button3.Name = "button3";
            button3.Size = new Size(51, 45);
            button3.TabIndex = 6;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(40, 40, 40);
            panel3.Location = new Point(-29, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(134, 273);
            panel3.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(637, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(757, 463);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "UniV";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button3;
        private Button button4;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}