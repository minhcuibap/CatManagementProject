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
            ((System.ComponentModel.ISupportInitialize)dgvServiceList).BeginInit();
            SuspendLayout();
            // 
            // dgvServiceList
            // 
            dgvServiceList.AllowUserToAddRows = false;
            dgvServiceList.AllowUserToResizeColumns = false;
            dgvServiceList.AllowUserToResizeRows = false;
            dgvServiceList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiceList.Location = new Point(65, 78);
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
            label2.Location = new Point(65, 29);
            label2.Name = "label2";
            label2.Size = new Size(185, 46);
            label2.TabIndex = 3;
            label2.Text = "Service List";
            // 
            // btnInitCreate
            // 
            btnInitCreate.Location = new Point(65, 399);
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
            btnInitUpdate.Location = new Point(586, 450);
            btnInitUpdate.Name = "btnInitUpdate";
            btnInitUpdate.Size = new Size(125, 50);
            btnInitUpdate.TabIndex = 5;
            btnInitUpdate.Text = "Update Service";
            btnInitUpdate.UseVisualStyleBackColor = true;
            btnInitUpdate.Click += btnInitUpdate_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(586, 399);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 402);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 7;
            label3.Text = "Service ID";
            // 
            // ServiceList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(btnInitUpdate);
            Controls.Add(btnInitCreate);
            Controls.Add(label2);
            Controls.Add(dgvServiceList);
            Name = "ServiceList";
            Text = "StaffDashboard";
            ((System.ComponentModel.ISupportInitialize)dgvServiceList).EndInit();
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
    }
}