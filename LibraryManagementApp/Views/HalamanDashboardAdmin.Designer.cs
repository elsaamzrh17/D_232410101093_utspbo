namespace LibraryManagementApp.Views
{
    partial class HalamanDashboardAdmin
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
            dataGridView1 = new DataGridView();
            btnTambahBuku = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(776, 258);
            dataGridView1.TabIndex = 0;
            // 
            // btnTambahBuku
            // 
            btnTambahBuku.BackColor = Color.Green;
            btnTambahBuku.ForeColor = Color.White;
            btnTambahBuku.Location = new Point(626, 368);
            btnTambahBuku.Name = "btnTambahBuku";
            btnTambahBuku.Size = new Size(112, 41);
            btnTambahBuku.TabIndex = 1;
            btnTambahBuku.Text = "Tambah";
            btnTambahBuku.UseVisualStyleBackColor = false;
            btnTambahBuku.Click += btnTambahBuku_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(280, 28);
            label1.Name = "label1";
            label1.Size = new Size(289, 22);
            label1.TabIndex = 2;
            label1.Text = "Daftar Buku Library App";
            // 
            // HalamanDashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnTambahBuku);
            Controls.Add(dataGridView1);
            Name = "HalamanDashboardAdmin";
            Text = "HalamanDashboardAdmin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnTambahBuku;
        private Label label1;
    }
}