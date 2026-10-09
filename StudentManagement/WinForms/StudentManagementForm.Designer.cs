namespace StudentSubjectManagement
{
    partial class StudentManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            txtEmail = new TextBox();
            txtDienThoai = new TextBox();
            nudDiemGiuaKy = new NumericUpDown();
            dgvDanhSach = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            linkLabel3 = new LinkLabel();
            nudDiemCuoiKy = new NumericUpDown();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDiemGiuaKy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDiemCuoiKy).BeginInit();
            SuspendLayout();
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(150, 100);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(250, 27);
            txtMaSV.TabIndex = 0;
            txtMaSV.TextChanged += textBox1_TextChanged_2;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(570, 100);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(250, 27);
            txtHoTen.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(570, 160);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(250, 27);
            txtDienThoai.TabIndex = 3;
            // 
            // nudDiemGiuaKy
            // 
            nudDiemGiuaKy.DecimalPlaces = 1;
            nudDiemGiuaKy.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudDiemGiuaKy.Location = new Point(150, 220);
            nudDiemGiuaKy.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDiemGiuaKy.Name = "nudDiemGiuaKy";
            nudDiemGiuaKy.Size = new Size(250, 27);
            nudDiemGiuaKy.TabIndex = 4;
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Location = new Point(3, 329);
            dgvDanhSach.MultiSelect = false;
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.RowHeadersWidth = 51;
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSach.Size = new Size(992, 317);
            dgvDanhSach.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(266, 280);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(526, 280);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(645, 280);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(399, 280);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 77);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 10;
            label1.Text = "Mã Sinh Viên";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 137);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 11;
            label2.Text = "Email";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(631, 248);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(570, 77);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 13;
            label3.Text = "Họ và Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(570, 137);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 14;
            label4.Text = "SĐT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 197);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 15;
            label5.Text = "Điểm Giữa Kỳ";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Segoe UI", 18F);
            linkLabel3.Location = new Point(362, 18);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(258, 41);
            linkLabel3.TabIndex = 17;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Quản Lý Sinh Viên";
            // 
            // nudDiemCuoiKy
            // 
            nudDiemCuoiKy.DecimalPlaces = 1;
            nudDiemCuoiKy.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudDiemCuoiKy.Location = new Point(570, 218);
            nudDiemCuoiKy.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDiemCuoiKy.Name = "nudDiemCuoiKy";
            nudDiemCuoiKy.Size = new Size(250, 27);
            nudDiemCuoiKy.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(570, 197);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 19;
            label6.Text = "Điểm Cuối Kỳ";
            // 
            // StudentManagementForm
            // 
            AutoSize = true;
            ClientSize = new Size(1000, 650);
            Controls.Add(label6);
            Controls.Add(nudDiemCuoiKy);
            Controls.Add(linkLabel3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvDanhSach);
            Controls.Add(nudDiemGiuaKy);
            Controls.Add(txtDienThoai);
            Controls.Add(txtEmail);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Name = "StudentManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            Load += StudentManagementForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)nudDiemGiuaKy).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDiemCuoiKy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private TextBox txtEmail;
        private TextBox txtDienThoai;
        private NumericUpDown nudDiemGiuaKy;
        private DataGridView dgvDanhSach;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel3;
        private NumericUpDown nudDiemCuoiKy;
        private Label label6;
    }
}