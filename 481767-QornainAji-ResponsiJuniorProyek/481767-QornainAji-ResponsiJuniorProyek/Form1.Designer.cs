namespace _481767_QornainAji_ResponsiJuniorProyek
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvTabel = new DataGridView();
            tbNamaKaryawan = new TextBox();
            cmbDepartemenKaryawan = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabel).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 32);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "logo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 77);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Karyawan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 102);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "Dep. Karyawan :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(550, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 131);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "ID Departemen";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 99);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 4;
            label8.Text = "FIN : Finance";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 78);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 3;
            label7.Text = "PM : Product M";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 59);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 2;
            label6.Text = "DEV : Developer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 43);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 1;
            label5.Text = "ENG : Engineer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 25);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 0;
            label4.Text = "HR: HR";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(64, 195);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(313, 195);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(572, 195);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvTabel
            // 
            dgvTabel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabel.Location = new Point(63, 252);
            dgvTabel.Name = "dgvTabel";
            dgvTabel.RowTemplate.Height = 25;
            dgvTabel.Size = new Size(638, 175);
            dgvTabel.TabIndex = 7;
            // 
            // tbNamaKaryawan
            // 
            tbNamaKaryawan.Location = new Point(142, 74);
            tbNamaKaryawan.Name = "tbNamaKaryawan";
            tbNamaKaryawan.Size = new Size(100, 23);
            tbNamaKaryawan.TabIndex = 8;
            // 
            // cmbDepartemenKaryawan
            // 
            cmbDepartemenKaryawan.FormattingEnabled = true;
            cmbDepartemenKaryawan.Location = new Point(142, 103);
            cmbDepartemenKaryawan.Name = "cmbDepartemenKaryawan";
            cmbDepartemenKaryawan.Size = new Size(121, 23);
            cmbDepartemenKaryawan.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbDepartemenKaryawan);
            Controls.Add(tbNamaKaryawan);
            Controls.Add(dgvTabel);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "orn";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvTabel;
        private TextBox tbNamaKaryawan;
        private ComboBox cmbDepartemenKaryawan;
    }
}
