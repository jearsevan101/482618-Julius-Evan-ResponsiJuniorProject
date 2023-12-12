namespace _482618_Julius_Evan_ResponsiJuniorProject
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmb_dep_karyawan = new ComboBox();
            tb_namaKaryawan = new TextBox();
            btn_Insert = new Button();
            btn_Edit = new Button();
            btn_Delete = new Button();
            dataGridView1 = new DataGridView();
            pic_Logo = new PictureBox();
            btn_Load = new Button();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Logo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 40);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Logo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 105);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Karyawan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 134);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Dep. Karyawan   :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(508, 7);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 3;
            label4.Text = "ID Departemen :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(508, 31);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 4;
            label5.Text = "HR : HR";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(508, 57);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 5;
            label6.Text = "ENG : Engineer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(508, 81);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 6;
            label7.Text = "DEV : Developer";
            // 
            // cmb_dep_karyawan
            // 
            cmb_dep_karyawan.FormattingEnabled = true;
            cmb_dep_karyawan.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cmb_dep_karyawan.Location = new Point(179, 133);
            cmb_dep_karyawan.Name = "cmb_dep_karyawan";
            cmb_dep_karyawan.Size = new Size(121, 23);
            cmb_dep_karyawan.TabIndex = 7;
            cmb_dep_karyawan.SelectedIndexChanged += cmb_dep_karyawan_SelectedIndexChanged;
            // 
            // tb_namaKaryawan
            // 
            tb_namaKaryawan.Location = new Point(180, 105);
            tb_namaKaryawan.Name = "tb_namaKaryawan";
            tb_namaKaryawan.Size = new Size(120, 23);
            tb_namaKaryawan.TabIndex = 8;
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(96, 200);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(75, 23);
            btn_Insert.TabIndex = 9;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(287, 200);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(75, 23);
            btn_Edit.TabIndex = 10;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(486, 200);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(75, 23);
            btn_Delete.TabIndex = 11;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 245);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(518, 168);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pic_Logo
            // 
            pic_Logo.Location = new Point(29, 22);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new Size(61, 50);
            pic_Logo.TabIndex = 17;
            pic_Logo.TabStop = false;
            // 
            // btn_Load
            // 
            btn_Load.Location = new Point(508, 419);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(75, 23);
            btn_Load.TabIndex = 18;
            btn_Load.Text = "Load";
            btn_Load.UseVisualStyleBackColor = true;
            btn_Load.Click += btn_Load_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(508, 108);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 19;
            label8.Text = "PM : Product M";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(510, 133);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 20;
            label9.Text = "FIN : Finance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btn_Load);
            Controls.Add(pic_Logo);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Insert);
            Controls.Add(tb_namaKaryawan);
            Controls.Add(cmb_dep_karyawan);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += btn_Load_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmb_dep_karyawan;
        private TextBox tb_namaKaryawan;
        private Button btn_Insert;
        private Button btn_Edit;
        private Button btn_Delete;
        private DataGridView dataGridView1;
        private PictureBox pic_Logo;
        private Button btn_Load;
        private Label label8;
        private Label label9;
    }
}