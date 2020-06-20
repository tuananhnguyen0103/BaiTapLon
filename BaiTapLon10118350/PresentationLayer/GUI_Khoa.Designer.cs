namespace BaiTapLon10118350.PresentationLayer
{
    partial class GUI_Khoa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Khoa));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgridview = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVPK = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.layoutHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.layoutHeaderInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.Layout1Chia = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.clMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridview)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.layoutHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.layoutHeaderInfo.SuspendLayout();
            this.Layout1Chia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.dtgridview, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 354F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(934, 354);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dtgridview
            // 
            this.dtgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaKhoa,
            this.clTenKhoa,
            this.clVPK,
            this.clSDT});
            this.dtgridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgridview.Location = new System.Drawing.Point(3, 3);
            this.dtgridview.Name = "dtgridview";
            this.dtgridview.Size = new System.Drawing.Size(647, 348);
            this.dtgridview.TabIndex = 0;
            this.dtgridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridview_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel14, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(656, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(275, 348);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 4;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.Controls.Add(this.btnMoi, 3, 0);
            this.tableLayoutPanel14.Controls.Add(this.btnXoa, 2, 0);
            this.tableLayoutPanel14.Controls.Add(this.btnSua, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 315);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(269, 30);
            this.tableLayoutPanel14.TabIndex = 2;
            // 
            // btnMoi
            // 
            this.btnMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnMoi.Image")));
            this.btnMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoi.Location = new System.Drawing.Point(211, 1);
            this.btnMoi.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(48, 28);
            this.btnMoi.TabIndex = 3;
            this.btnMoi.Text = "Làm mới";
            this.btnMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(144, 1);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 28);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(77, 1);
            this.btnSua.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(47, 28);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(10, 1);
            this.btnThem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(47, 28);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khoa";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.55894F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.44106F));
            this.tableLayoutPanel3.Controls.Add(this.txtSDT, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtVPK, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtTenKhoa, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtMaKhoa, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(263, 212);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.Location = new System.Drawing.Point(86, 118);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(147, 16);
            this.txtSDT.TabIndex = 7;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "SĐT:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVPK
            // 
            this.txtVPK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVPK.Location = new System.Drawing.Point(86, 82);
            this.txtVPK.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.txtVPK.Multiline = true;
            this.txtVPK.Name = "txtVPK";
            this.txtVPK.Size = new System.Drawing.Size(147, 16);
            this.txtVPK.TabIndex = 5;
            this.txtVPK.TextChanged += new System.EventHandler(this.txtVPK_TextChanged);
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenKhoa.Location = new System.Drawing.Point(86, 46);
            this.txtTenKhoa.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.txtTenKhoa.Multiline = true;
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(147, 16);
            this.txtTenKhoa.TabIndex = 3;
            this.txtTenKhoa.TextChanged += new System.EventHandler(this.txtTenKhoa_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên khoa:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã khoa:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaKhoa.Location = new System.Drawing.Point(86, 10);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.txtMaKhoa.Multiline = true;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(147, 16);
            this.txtMaKhoa.TabIndex = 1;
            this.txtMaKhoa.TextChanged += new System.EventHandler(this.txtMaKhoa_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "VPK:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 246);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(269, 63);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.btnThoat, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnLuu, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(263, 26);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(219, 0);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(34, 26);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(167, 0);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(32, 26);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // layoutHeader
            // 
            this.layoutHeader.ColumnCount = 3;
            this.layoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.layoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutHeader.Controls.Add(this.pictureBox1, 0, 0);
            this.layoutHeader.Controls.Add(this.layoutHeaderInfo, 2, 0);
            this.layoutHeader.Controls.Add(this.label10, 1, 0);
            this.layoutHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutHeader.Location = new System.Drawing.Point(4, 4);
            this.layoutHeader.Margin = new System.Windows.Forms.Padding(4);
            this.layoutHeader.Name = "layoutHeader";
            this.layoutHeader.RowCount = 1;
            this.layoutHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutHeader.Size = new System.Drawing.Size(932, 82);
            this.layoutHeader.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // layoutHeaderInfo
            // 
            this.layoutHeaderInfo.BackColor = System.Drawing.Color.Green;
            this.layoutHeaderInfo.ColumnCount = 1;
            this.layoutHeaderInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutHeaderInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.layoutHeaderInfo.Controls.Add(this.label1, 0, 0);
            this.layoutHeaderInfo.Controls.Add(this.label2, 0, 1);
            this.layoutHeaderInfo.Controls.Add(this.label3, 0, 2);
            this.layoutHeaderInfo.Controls.Add(this.linkLabel1, 0, 3);
            this.layoutHeaderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutHeaderInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.layoutHeaderInfo.Location = new System.Drawing.Point(702, 4);
            this.layoutHeaderInfo.Margin = new System.Windows.Forms.Padding(4);
            this.layoutHeaderInfo.Name = "layoutHeaderInfo";
            this.layoutHeaderInfo.RowCount = 4;
            this.layoutHeaderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutHeaderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutHeaderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutHeaderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutHeaderInfo.Size = new System.Drawing.Size(226, 74);
            this.layoutHeaderInfo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên: Nguyễn Đức Tuấn Anh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên: 10118350";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp: 101181";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkLabel1.Location = new System.Drawing.Point(4, 54);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(218, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Email: tuananh010320@gmail.com";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Green;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(96, 4);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(599, 74);
            this.label10.TabIndex = 3;
            this.label10.Text = "Danh sách khoa";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Layout1Chia
            // 
            this.Layout1Chia.ColumnCount = 1;
            this.Layout1Chia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout1Chia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Layout1Chia.Controls.Add(this.layoutHeader, 0, 0);
            this.Layout1Chia.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.Layout1Chia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout1Chia.Location = new System.Drawing.Point(0, 0);
            this.Layout1Chia.Name = "Layout1Chia";
            this.Layout1Chia.RowCount = 2;
            this.Layout1Chia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Layout1Chia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.Layout1Chia.Size = new System.Drawing.Size(940, 450);
            this.Layout1Chia.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // clMaKhoa
            // 
            this.clMaKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMaKhoa.DataPropertyName = "maKhoa";
            this.clMaKhoa.HeaderText = "Mã Khoa";
            this.clMaKhoa.Name = "clMaKhoa";
            // 
            // clTenKhoa
            // 
            this.clTenKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenKhoa.DataPropertyName = "tenKhoa";
            this.clTenKhoa.HeaderText = "Tên Khoa";
            this.clTenKhoa.Name = "clTenKhoa";
            // 
            // clVPK
            // 
            this.clVPK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clVPK.DataPropertyName = "vanPhongKhoa";
            this.clVPK.HeaderText = "Văn Phòng";
            this.clVPK.Name = "clVPK";
            // 
            // clSDT
            // 
            this.clSDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSDT.DataPropertyName = "soDienThoai";
            this.clSDT.HeaderText = "Số điện thoại";
            this.clSDT.Name = "clSDT";
            // 
            // GUI_Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.Layout1Chia);
            this.Name = "GUI_Khoa";
            this.Text = "GUI_Khoa";
            this.Load += new System.EventHandler(this.GUI_Khoa_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridview)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.layoutHeader.ResumeLayout(false);
            this.layoutHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.layoutHeaderInfo.ResumeLayout(false);
            this.layoutHeaderInfo.PerformLayout();
            this.Layout1Chia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dtgridview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel layoutHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel layoutHeaderInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel Layout1Chia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtVPK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;
    }
}