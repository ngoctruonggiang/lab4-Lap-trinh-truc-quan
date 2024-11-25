namespace Bai05
{
    partial class FormThemSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemSinhVien));
            labelMaSoSinhVien = new Label();
            labelTenSinhVien = new Label();
            labelKhoa = new Label();
            label1DiemTB = new Label();
            textBoxMaSoSinhVien = new TextBox();
            textBoxTenSinhVien = new TextBox();
            textBoxKhoa = new TextBox();
            textBoxDiemTB = new TextBox();
            button1 = new Button();
            buttonXoa = new Button();
            SuspendLayout();
            // 
            // labelMaSoSinhVien
            // 
            labelMaSoSinhVien.AutoSize = true;
            labelMaSoSinhVien.Font = new Font("Century", 12F, FontStyle.Bold);
            labelMaSoSinhVien.Location = new Point(122, 61);
            labelMaSoSinhVien.Margin = new Padding(5, 0, 5, 0);
            labelMaSoSinhVien.Name = "labelMaSoSinhVien";
            labelMaSoSinhVien.Size = new Size(180, 23);
            labelMaSoSinhVien.TabIndex = 0;
            labelMaSoSinhVien.Text = "Mã Số Sinh Viên";
            // 
            // labelTenSinhVien
            // 
            labelTenSinhVien.AutoSize = true;
            labelTenSinhVien.Font = new Font("Century", 12F, FontStyle.Bold);
            labelTenSinhVien.Location = new Point(122, 130);
            labelTenSinhVien.Margin = new Padding(5, 0, 5, 0);
            labelTenSinhVien.Name = "labelTenSinhVien";
            labelTenSinhVien.Size = new Size(155, 23);
            labelTenSinhVien.TabIndex = 1;
            labelTenSinhVien.Text = "Tên Sinh Viên";
            // 
            // labelKhoa
            // 
            labelKhoa.AutoSize = true;
            labelKhoa.Font = new Font("Century", 12F, FontStyle.Bold);
            labelKhoa.Location = new Point(122, 193);
            labelKhoa.Margin = new Padding(5, 0, 5, 0);
            labelKhoa.Name = "labelKhoa";
            labelKhoa.Size = new Size(63, 23);
            labelKhoa.TabIndex = 2;
            labelKhoa.Text = "Khoa";
            // 
            // label1DiemTB
            // 
            label1DiemTB.AutoSize = true;
            label1DiemTB.Font = new Font("Century", 12F, FontStyle.Bold);
            label1DiemTB.Location = new Point(122, 256);
            label1DiemTB.Margin = new Padding(5, 0, 5, 0);
            label1DiemTB.Name = "label1DiemTB";
            label1DiemTB.Size = new Size(99, 23);
            label1DiemTB.TabIndex = 3;
            label1DiemTB.Text = "Điểm TB";
            // 
            // textBoxMaSoSinhVien
            // 
            textBoxMaSoSinhVien.Location = new Point(353, 53);
            textBoxMaSoSinhVien.Margin = new Padding(5, 3, 5, 3);
            textBoxMaSoSinhVien.Name = "textBoxMaSoSinhVien";
            textBoxMaSoSinhVien.Size = new Size(514, 32);
            textBoxMaSoSinhVien.TabIndex = 4;
            // 
            // textBoxTenSinhVien
            // 
            textBoxTenSinhVien.Location = new Point(353, 122);
            textBoxTenSinhVien.Margin = new Padding(5, 3, 5, 3);
            textBoxTenSinhVien.Name = "textBoxTenSinhVien";
            textBoxTenSinhVien.Size = new Size(620, 32);
            textBoxTenSinhVien.TabIndex = 5;
            // 
            // textBoxKhoa
            // 
            textBoxKhoa.Location = new Point(353, 185);
            textBoxKhoa.Margin = new Padding(5, 3, 5, 3);
            textBoxKhoa.Name = "textBoxKhoa";
            textBoxKhoa.Size = new Size(514, 32);
            textBoxKhoa.TabIndex = 6;
            // 
            // textBoxDiemTB
            // 
            textBoxDiemTB.Location = new Point(353, 253);
            textBoxDiemTB.Margin = new Padding(5, 3, 5, 3);
            textBoxDiemTB.Name = "textBoxDiemTB";
            textBoxDiemTB.Size = new Size(201, 32);
            textBoxDiemTB.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(343, 443);
            button1.Margin = new Padding(5, 3, 5, 3);
            button1.Name = "button1";
            button1.Size = new Size(226, 46);
            button1.TabIndex = 8;
            button1.Text = "Thêm Mới";
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = Color.IndianRed;
            buttonXoa.Location = new Point(603, 443);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(204, 46);
            buttonXoa.TabIndex = 9;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            // 
            // FormThemSinhVien
            // 
            AutoScaleDimensions = new SizeF(13F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 553);
            Controls.Add(buttonXoa);
            Controls.Add(button1);
            Controls.Add(textBoxDiemTB);
            Controls.Add(textBoxKhoa);
            Controls.Add(textBoxTenSinhVien);
            Controls.Add(textBoxMaSoSinhVien);
            Controls.Add(label1DiemTB);
            Controls.Add(labelKhoa);
            Controls.Add(labelTenSinhVien);
            Controls.Add(labelMaSoSinhVien);
            Font = new Font("Century", 12F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 3, 5, 3);
            Name = "FormThemSinhVien";
            Text = "Thêm Sinh Viên";
            Load += FormThemSinhVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMaSoSinhVien;
        private Label labelTenSinhVien;
        private Label labelKhoa;
        private Label label1DiemTB;
        private TextBox textBoxMaSoSinhVien;
        private TextBox textBoxTenSinhVien;
        private TextBox textBoxKhoa;
        private TextBox textBoxDiemTB;
        private Button button1;
        private Button buttonXoa;
    }
}