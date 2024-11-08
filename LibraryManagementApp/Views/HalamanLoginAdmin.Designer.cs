namespace LibraryManagementApp.Views
{
    partial class HalamanLoginAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnMasukAdmin = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 153);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 210);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // btnMasukAdmin
            // 
            btnMasukAdmin.BackColor = Color.FromArgb(64, 0, 64);
            btnMasukAdmin.ForeColor = Color.White;
            btnMasukAdmin.Location = new Point(586, 328);
            btnMasukAdmin.Name = "btnMasukAdmin";
            btnMasukAdmin.Size = new Size(112, 42);
            btnMasukAdmin.TabIndex = 2;
            btnMasukAdmin.Text = "Masuk";
            btnMasukAdmin.UseVisualStyleBackColor = false;
            btnMasukAdmin.Click += btnMasukAdmin_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(290, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(290, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(329, 31);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(218, 52);
            label3.Name = "label3";
            label3.Size = new Size(377, 42);
            label3.TabIndex = 5;
            label3.Text = "LOGIN LIBRARY APP";
            label3.Click += label3_Click;
            // 
            // HalamanLoginAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnMasukAdmin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HalamanLoginAdmin";
            Text = "Halaman Login Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnMasukAdmin;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
    }
}