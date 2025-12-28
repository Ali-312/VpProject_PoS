namespace VpProject_PoS
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(179, 131, 87);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(468, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 450);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(86, 177);
            label3.Name = "label3";
            label3.Size = new Size(183, 50);
            label3.TabIndex = 3;
            label3.Text = "PoS Invoice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 224, 192);
            label2.Location = new Point(95, 90);
            label2.Name = "label2";
            label2.Size = new Size(225, 67);
            label2.TabIndex = 2;
            label2.Text = "Cafeteria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 224, 192);
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(180, 67);
            label1.TabIndex = 1;
            label1.Text = "Arian's";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 253);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Arial Black", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 23);
            label4.Name = "label4";
            label4.Size = new Size(341, 75);
            label4.TabIndex = 1;
            label4.Text = "User Login";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 147);
            label5.Name = "label5";
            label5.Size = new Size(183, 40);
            label5.TabIndex = 2;
            label5.Text = "Username:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 253);
            label6.Name = "label6";
            label6.Size = new Size(175, 40);
            label6.TabIndex = 3;
            label6.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(35, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(35, 296);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '.';
            textBox2.Size = new Size(343, 35);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(106, 365);
            button1.Name = "button1";
            button1.Size = new Size(165, 57);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}
