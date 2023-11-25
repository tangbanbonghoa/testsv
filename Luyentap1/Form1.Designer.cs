namespace Luyentap1
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
            components = new System.ComponentModel.Container();
            dgvNoiDung = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            STT = new DataGridViewTextBoxColumn();
            tenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loaihangDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngaydangkyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cuahangBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            dtnTime = new DateTimePicker();
            txtLoaiHang = new TextBox();
            txtMota = new TextBox();
            txtTen = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtdtn = new TextBox();
            groupBox2 = new GroupBox();
            btnShow = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNoiDung).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cuahangBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNoiDung
            // 
            dgvNoiDung.AllowUserToAddRows = false;
            dgvNoiDung.AllowUserToDeleteRows = false;
            dgvNoiDung.AutoGenerateColumns = false;
            dgvNoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNoiDung.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, STT, tenDataGridViewTextBoxColumn, motaDataGridViewTextBoxColumn, loaihangDataGridViewTextBoxColumn, ngaydangkyDataGridViewTextBoxColumn });
            dgvNoiDung.DataSource = cuahangBindingSource;
            dgvNoiDung.Location = new Point(33, 322);
            dgvNoiDung.Name = "dgvNoiDung";
            dgvNoiDung.ReadOnly = true;
            dgvNoiDung.RowHeadersWidth = 51;
            dgvNoiDung.RowTemplate.Height = 29;
            dgvNoiDung.Size = new Size(785, 374);
            dgvNoiDung.TabIndex = 0;
            dgvNoiDung.Click += dgvNoiDung_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // STT
            // 
            STT.DataPropertyName = "Id";
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Width = 125;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            tenDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            tenDataGridViewTextBoxColumn.ReadOnly = true;
            tenDataGridViewTextBoxColumn.Width = 125;
            // 
            // motaDataGridViewTextBoxColumn
            // 
            motaDataGridViewTextBoxColumn.DataPropertyName = "Mota";
            motaDataGridViewTextBoxColumn.HeaderText = "Mota";
            motaDataGridViewTextBoxColumn.MinimumWidth = 6;
            motaDataGridViewTextBoxColumn.Name = "motaDataGridViewTextBoxColumn";
            motaDataGridViewTextBoxColumn.ReadOnly = true;
            motaDataGridViewTextBoxColumn.Width = 125;
            // 
            // loaihangDataGridViewTextBoxColumn
            // 
            loaihangDataGridViewTextBoxColumn.DataPropertyName = "Loaihang";
            loaihangDataGridViewTextBoxColumn.HeaderText = "Loaihang";
            loaihangDataGridViewTextBoxColumn.MinimumWidth = 6;
            loaihangDataGridViewTextBoxColumn.Name = "loaihangDataGridViewTextBoxColumn";
            loaihangDataGridViewTextBoxColumn.ReadOnly = true;
            loaihangDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaydangkyDataGridViewTextBoxColumn
            // 
            ngaydangkyDataGridViewTextBoxColumn.DataPropertyName = "Ngaydangky";
            ngaydangkyDataGridViewTextBoxColumn.HeaderText = "Ngaydangky";
            ngaydangkyDataGridViewTextBoxColumn.MinimumWidth = 6;
            ngaydangkyDataGridViewTextBoxColumn.Name = "ngaydangkyDataGridViewTextBoxColumn";
            ngaydangkyDataGridViewTextBoxColumn.ReadOnly = true;
            ngaydangkyDataGridViewTextBoxColumn.Width = 125;
            // 
            // cuahangBindingSource
            // 
            cuahangBindingSource.DataSource = typeof(A_DAL.Models.Cuahang);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(dtnTime);
            groupBox1.Controls.Add(txtLoaiHang);
            groupBox1.Controls.Add(txtMota);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtdtn);
            groupBox1.Location = new Point(21, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(620, 255);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(352, 65);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 9;
            // 
            // dtnTime
            // 
            dtnTime.Format = DateTimePickerFormat.Short;
            dtnTime.Location = new Point(93, 204);
            dtnTime.Name = "dtnTime";
            dtnTime.Size = new Size(250, 27);
            dtnTime.TabIndex = 7;
            dtnTime.TabStop = false;
            dtnTime.ValueChanged += dtnTime_ValueChanged;
            // 
            // txtLoaiHang
            // 
            txtLoaiHang.Location = new Point(110, 152);
            txtLoaiHang.Name = "txtLoaiHang";
            txtLoaiHang.Size = new Size(125, 27);
            txtLoaiHang.TabIndex = 6;
            // 
            // txtMota
            // 
            txtMota.Location = new Point(121, 98);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(125, 27);
            txtMota.TabIndex = 5;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(111, 35);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(125, 27);
            txtTen.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 209);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 146);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 93);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 34);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // txtdtn
            // 
            txtdtn.Location = new Point(93, 202);
            txtdtn.Name = "txtdtn";
            txtdtn.Size = new Size(250, 27);
            txtdtn.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnShow);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Location = new Point(692, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(126, 255);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(6, 191);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 3;
            btnShow.Text = "button4";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(24, 135);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "button3";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(23, 87);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "button2";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(23, 45);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "button1";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 708);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvNoiDung);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNoiDung).EndInit();
            ((System.ComponentModel.ISupportInitialize)cuahangBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvNoiDung;
        private GroupBox groupBox1;
        private TextBox txtLoaiHang;
        private TextBox txtMota;
        private TextBox txtTen;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnShow;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loaihangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaydangkyDataGridViewTextBoxColumn;
        private BindingSource cuahangBindingSource;
        private DateTimePicker dtnTime;
        private TextBox txtdtn;
        private NumericUpDown numericUpDown1;
    }
}