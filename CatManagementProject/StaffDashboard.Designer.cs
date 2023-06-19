namespace CatManagementProject
{
    partial class StaffDashboard
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
            dgvRegisteredServiceList = new DataGridView();
            dgvServiceList = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnInitCreate = new Button();
            btnInitUpdate = new Button();
            txtID = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRegisteredServiceList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServiceList).BeginInit();
            SuspendLayout();
            // 
            // dgvRegisteredServiceList
            // 
            dgvRegisteredServiceList.AllowUserToResizeColumns = false;
            dgvRegisteredServiceList.AllowUserToResizeRows = false;
            dgvRegisteredServiceList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegisteredServiceList.Location = new Point(12, 68);
            dgvRegisteredServiceList.Name = "dgvRegisteredServiceList";
            dgvRegisteredServiceList.ReadOnly = true;
            dgvRegisteredServiceList.RowHeadersWidth = 51;
            dgvRegisteredServiceList.RowTemplate.Height = 29;
            dgvRegisteredServiceList.Size = new Size(801, 298);
            dgvRegisteredServiceList.TabIndex = 0;
            // 
            // dgvServiceList
            // 
            dgvServiceList.AllowUserToResizeColumns = false;
            dgvServiceList.AllowUserToResizeRows = false;
            dgvServiceList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiceList.Location = new Point(12, 444);
            dgvServiceList.Name = "dgvServiceList";
            dgvServiceList.ReadOnly = true;
            dgvServiceList.RowHeadersWidth = 51;
            dgvServiceList.RowTemplate.Height = 29;
            dgvServiceList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServiceList.Size = new Size(646, 217);
            dgvServiceList.TabIndex = 1;
            dgvServiceList.CellClick += dgvServiceList_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(353, 46);
            label1.TabIndex = 2;
            label1.Text = "Registered Service List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 395);
            label2.Name = "label2";
            label2.Size = new Size(185, 46);
            label2.TabIndex = 3;
            label2.Text = "Service List";
            // 
            // btnInitCreate
            // 
            btnInitCreate.Location = new Point(730, 518);
            btnInitCreate.Name = "btnInitCreate";
            btnInitCreate.Size = new Size(151, 29);
            btnInitCreate.TabIndex = 4;
            btnInitCreate.Text = "Create New Service";
            btnInitCreate.UseVisualStyleBackColor = true;
            btnInitCreate.Click += btnInitCreate_Click;
            // 
            // btnInitUpdate
            // 
            btnInitUpdate.Enabled = false;
            btnInitUpdate.Location = new Point(730, 446);
            btnInitUpdate.Name = "btnInitUpdate";
            btnInitUpdate.Size = new Size(151, 29);
            btnInitUpdate.TabIndex = 5;
            btnInitUpdate.Text = "Update Service";
            btnInitUpdate.UseVisualStyleBackColor = true;
            btnInitUpdate.Click += btnInitUpdate_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(992, 446);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(911, 449);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 7;
            label3.Text = "Service ID";
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(btnInitUpdate);
            Controls.Add(btnInitCreate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvServiceList);
            Controls.Add(dgvRegisteredServiceList);
            Name = "StaffDashboard";
            Text = "StaffDashboard";
            ((System.ComponentModel.ISupportInitialize)dgvRegisteredServiceList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServiceList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRegisteredServiceList;
        private DataGridView dgvServiceList;
        private Label label1;
        private Label label2;
        private Button btnInitCreate;
        private Button btnInitUpdate;
        private TextBox txtID;
        private Label label3;
    }
}