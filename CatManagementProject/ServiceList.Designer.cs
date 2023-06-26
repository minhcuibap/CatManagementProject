namespace CatManagementProject
{
    partial class ServiceList
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
            dgvServiceList = new DataGridView();
            label2 = new Label();
            btnInitCreate = new Button();
            btnInitUpdate = new Button();
            txtID = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            btnLogOut = new Button();
            btnServices = new Button();
            btnCat = new Button();
            btnManager = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvServiceList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvServiceList
            // 
            dgvServiceList.AllowUserToAddRows = false;
            dgvServiceList.AllowUserToResizeColumns = false;
            dgvServiceList.AllowUserToResizeRows = false;
            dgvServiceList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiceList.Location = new Point(305, 79);
            dgvServiceList.Name = "dgvServiceList";
            dgvServiceList.ReadOnly = true;
            dgvServiceList.RowHeadersWidth = 51;
            dgvServiceList.RowTemplate.Height = 29;
            dgvServiceList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServiceList.Size = new Size(646, 288);
            dgvServiceList.TabIndex = 1;
            dgvServiceList.CellClick += dgvServiceList_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(305, 18);
            label2.Name = "label2";
            label2.Size = new Size(185, 46);
            label2.TabIndex = 3;
            label2.Text = "Service List";
            // 
            // btnInitCreate
            // 
            btnInitCreate.Location = new Point(305, 399);
            btnInitCreate.Name = "btnInitCreate";
            btnInitCreate.Size = new Size(150, 50);
            btnInitCreate.TabIndex = 4;
            btnInitCreate.Text = "Create New Service";
            btnInitCreate.UseVisualStyleBackColor = true;
            btnInitCreate.Click += btnInitCreate_Click;
            // 
            // btnInitUpdate
            // 
            btnInitUpdate.Enabled = false;
            btnInitUpdate.Location = new Point(810, 455);
            btnInitUpdate.Name = "btnInitUpdate";
            btnInitUpdate.Size = new Size(125, 50);
            btnInitUpdate.TabIndex = 5;
            btnInitUpdate.Text = "Update Service";
            btnInitUpdate.UseVisualStyleBackColor = true;
            btnInitUpdate.Click += btnInitUpdate_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(810, 399);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(704, 406);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 7;
            label3.Text = "Service ID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnServices);
            panel1.Controls.Add(btnCat);
            panel1.Controls.Add(btnManager);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 673);
            panel1.TabIndex = 8;
            // 
            // btnLogOut
            // 
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.Location = new Point(0, 382);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(250, 79);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnServices
            // 
            btnServices.FlatAppearance.BorderSize = 0;
            btnServices.FlatStyle = FlatStyle.Flat;
            btnServices.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnServices.Location = new Point(0, 297);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(250, 79);
            btnServices.TabIndex = 3;
            btnServices.Text = "Services";
            btnServices.UseVisualStyleBackColor = true;
            btnServices.Click += btnServices_Click;
            // 
            // btnCat
            // 
            btnCat.FlatAppearance.BorderSize = 0;
            btnCat.FlatStyle = FlatStyle.Flat;
            btnCat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCat.Location = new Point(0, 210);
            btnCat.Name = "btnCat";
            btnCat.Size = new Size(250, 79);
            btnCat.TabIndex = 2;
            btnCat.Text = "Cat";
            btnCat.UseVisualStyleBackColor = true;
            // 
            // btnManager
            // 
            btnManager.FlatAppearance.BorderSize = 0;
            btnManager.FlatStyle = FlatStyle.Flat;
            btnManager.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnManager.Location = new Point(0, 125);
            btnManager.Name = "btnManager";
            btnManager.Size = new Size(250, 79);
            btnManager.TabIndex = 1;
            btnManager.Text = "Manager";
            btnManager.UseVisualStyleBackColor = true;
            btnManager.Click += btnManager_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 125);
            panel2.TabIndex = 0;
            // 
            // ServiceList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(btnInitUpdate);
            Controls.Add(btnInitCreate);
            Controls.Add(label2);
            Controls.Add(dgvServiceList);
            Name = "ServiceList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffDashboard";
            ((System.ComponentModel.ISupportInitialize)dgvServiceList).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvServiceList;
        private Label label2;
        private Button btnInitCreate;
        private Button btnInitUpdate;
        private TextBox txtID;
        private Label label3;
        private Panel panel1;
        private Button btnLogOut;
        private Button btnServices;
        private Button btnCat;
        private Button btnManager;
        private Panel panel2;
    }
}