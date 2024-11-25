namespace Bai05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            thêmMớiToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            xemTấtCảSinhViênToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButtonThemMoi = new ToolStripButton();
            toolStripButtonSearchFrName = new ToolStripButton();
            toolStripTextBox1 = new ToolStripTextBox();
            dataGridView1 = new DataGridView();
            ColSTT = new DataGridViewTextBoxColumn();
            ColMSSV = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmMớiToolStripMenuItem, thoátToolStripMenuItem, xemTấtCảSinhViênToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(96, 24);
            chứcNăngToolStripMenuItem.Text = "Chức Năng";
            chứcNăngToolStripMenuItem.Click += chứcNăngToolStripMenuItem_Click;
            // 
            // thêmMớiToolStripMenuItem
            // 
            thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            thêmMớiToolStripMenuItem.Size = new Size(233, 26);
            thêmMớiToolStripMenuItem.Text = "Thêm Mới";
            thêmMớiToolStripMenuItem.Click += thêmMớiToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(233, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // xemTấtCảSinhViênToolStripMenuItem
            // 
            xemTấtCảSinhViênToolStripMenuItem.Name = "xemTấtCảSinhViênToolStripMenuItem";
            xemTấtCảSinhViênToolStripMenuItem.Size = new Size(233, 26);
            xemTấtCảSinhViênToolStripMenuItem.Text = "Xem Tất Cả Sinh Viên";
            xemTấtCảSinhViênToolStripMenuItem.Click += xemTấtCảSinhViênToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonThemMoi, toolStripButtonSearchFrName, toolStripTextBox1 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 30);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonThemMoi
            // 
            toolStripButtonThemMoi.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButtonThemMoi.Image = (Image)resources.GetObject("toolStripButtonThemMoi.Image");
            toolStripButtonThemMoi.ImageTransparentColor = Color.Magenta;
            toolStripButtonThemMoi.Name = "toolStripButtonThemMoi";
            toolStripButtonThemMoi.Size = new Size(135, 27);
            toolStripButtonThemMoi.Text = "Thêm Mới";
            toolStripButtonThemMoi.ToolTipText = "Thêm Mới                    ";
            toolStripButtonThemMoi.Click += toolStripButtonThemMoi_Click;
            // 
            // toolStripButtonSearchFrName
            // 
            toolStripButtonSearchFrName.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonSearchFrName.Image = (Image)resources.GetObject("toolStripButtonSearchFrName.Image");
            toolStripButtonSearchFrName.ImageTransparentColor = Color.Magenta;
            toolStripButtonSearchFrName.Name = "toolStripButtonSearchFrName";
            toolStripButtonSearchFrName.Size = new Size(140, 27);
            toolStripButtonSearchFrName.Text = "Tìm Kiếm Theo Tên";
            toolStripButtonSearchFrName.Click += toolStripButtonSearchFrName_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(300, 30);
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColSTT, ColMSSV });
            dataGridView1.Location = new Point(0, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 386);
            dataGridView1.TabIndex = 2;
            // 
            // ColSTT
            // 
            ColSTT.HeaderText = "So Thu Tu";
            ColSTT.MinimumWidth = 6;
            ColSTT.Name = "ColSTT";
            ColSTT.Width = 125;
            // 
            // ColMSSV
            // 
            ColMSSV.HeaderText = "Ma So Sinh Vien";
            ColMSSV.MinimumWidth = 6;
            ColMSSV.Name = "ColMSSV";
            ColMSSV.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Quản Lý Sinh Viên";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem thêmMớiToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonSearchFrName;
        private ToolStripButton toolStripButtonThemMoi;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripMenuItem xemTấtCảSinhViênToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColSTT;
        private DataGridViewTextBoxColumn ColMSSV;
    }
}
