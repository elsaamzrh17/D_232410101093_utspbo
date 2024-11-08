namespace LibraryManagementApp
{
    partial class HalamanWelcome
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
            label1 = new Label();
            label2 = new Label();
            MenuBuku = new Button();
            MenuPendaftaran = new Button();
            MenuLoginAdmin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(203, 74);
            label1.Name = "label1";
            label1.Size = new Size(381, 35);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO LIBRARY APP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(337, 109);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 1;
            // 
            // MenuBuku
            // 
            MenuBuku.BackColor = Color.FromArgb(224, 224, 224);
            MenuBuku.Location = new Point(102, 233);
            MenuBuku.Name = "MenuBuku";
            MenuBuku.Size = new Size(156, 77);
            MenuBuku.TabIndex = 2;
            MenuBuku.Text = "Buku";
            MenuBuku.UseVisualStyleBackColor = false;
            MenuBuku.Click += MenuBuku_Click;
            // 
            // MenuPendaftaran
            // 
            MenuPendaftaran.BackColor = Color.FromArgb(255, 192, 128);
            MenuPendaftaran.Location = new Point(320, 233);
            MenuPendaftaran.Name = "MenuPendaftaran";
            MenuPendaftaran.Size = new Size(156, 77);
            MenuPendaftaran.TabIndex = 3;
            MenuPendaftaran.Text = "Pendaftaran";
            MenuPendaftaran.UseVisualStyleBackColor = false;
            // 
            // MenuLoginAdmin
            // 
            MenuLoginAdmin.BackColor = SystemColors.ActiveCaption;
            MenuLoginAdmin.Location = new Point(532, 233);
            MenuLoginAdmin.Name = "MenuLoginAdmin";
            MenuLoginAdmin.Size = new Size(156, 77);
            MenuLoginAdmin.TabIndex = 4;
            MenuLoginAdmin.Text = "Login Admin";
            MenuLoginAdmin.UseVisualStyleBackColor = false;
            MenuLoginAdmin.Click += MenuLoginAdmin_Click;
            // 
            // HalamanWelcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MenuLoginAdmin);
            Controls.Add(MenuPendaftaran);
            Controls.Add(MenuBuku);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HalamanWelcome";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button MenuBuku;
        private Button MenuPendaftaran;
        private Button MenuLoginAdmin;
    }
}
