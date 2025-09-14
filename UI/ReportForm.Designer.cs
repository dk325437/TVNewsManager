namespace TVNewsManager.UI
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblReporter;
        private System.Windows.Forms.ComboBox cmbReporter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvReports;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblReporter = new System.Windows.Forms.Label();
            this.cmbReporter = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Tiêu đề:";
            this.lblTitle.AutoSize = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(100, 20);
            this.txtTitle.Size = new System.Drawing.Size(200, 23);
            // 
            // lblDuration
            // 
            this.lblDuration.Location = new System.Drawing.Point(20, 60);
            this.lblDuration.Text = "Thời lượng (phút):";
            this.lblDuration.AutoSize = true;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(150, 60);
            this.txtDuration.Size = new System.Drawing.Size(100, 23);
            // 
            // lblReporter
            // 
            this.lblReporter.Location = new System.Drawing.Point(20, 100);
            this.lblReporter.Text = "Phóng viên:";
            this.lblReporter.AutoSize = true;
            // 
            // cmbReporter
            // 
            this.cmbReporter.Location = new System.Drawing.Point(100, 100);
            this.cmbReporter.Size = new System.Drawing.Size(200, 23);
            this.cmbReporter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(350, 20);
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(350, 60);
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(350, 100);
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(250, 320);
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.Text = "Quay lại";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvReports
            // 
            this.dgvReports.Location = new System.Drawing.Point(20, 150);
            this.dgvReports.Size = new System.Drawing.Size(600, 150);
            this.dgvReports.ReadOnly = true;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.Columns.Add("TieuDe", "Tiêu đề");
            this.dgvReports.Columns.Add("ThoiLuong", "Thời lượng");
            this.dgvReports.Columns.Add("PhongVien", "Phóng viên");
            // 
            // ReportForm
            // 
            this.ClientSize = new System.Drawing.Size(650, 380);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblReporter);
            this.Controls.Add(this.cmbReporter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvReports);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Phóng Sự";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
