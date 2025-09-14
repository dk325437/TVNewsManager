namespace TVNewsManager.UI
{
    partial class PersonForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvPersons;

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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Text = "Họ tên:";
            this.lblName.AutoSize = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 20);
            this.txtName.Size = new System.Drawing.Size(200, 23);
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(20, 60);
            this.lblEmail.Text = "Email:";
            this.lblEmail.AutoSize = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 60);
            this.txtEmail.Size = new System.Drawing.Size(200, 23);
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(20, 100);
            this.lblPhone.Text = "Số điện thoại:";
            this.lblPhone.AutoSize = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 100);
            this.txtPhone.Size = new System.Drawing.Size(200, 23);
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(20, 140);
            this.lblType.Text = "Loại:";
            this.lblType.AutoSize = true;
            // 
            // cmbType
            // 
            this.cmbType.Location = new System.Drawing.Point(120, 140);
            this.cmbType.Size = new System.Drawing.Size(200, 23);
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // dgvPersons
            // 
            this.dgvPersons.Location = new System.Drawing.Point(20, 180);
            this.dgvPersons.Size = new System.Drawing.Size(600, 120);
            this.dgvPersons.ReadOnly = true;
            this.dgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersons.Columns.Add("HoTen", "Họ tên");
            this.dgvPersons.Columns.Add("Email", "Email");
            this.dgvPersons.Columns.Add("SoDienThoai", "Số điện thoại");
            this.dgvPersons.Columns.Add("Loai", "Loại");
            // 
            // PersonForm
            // 
            this.ClientSize = new System.Drawing.Size(650, 380);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvPersons);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Nhân Sự";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
