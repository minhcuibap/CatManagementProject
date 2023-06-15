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
            ((System.ComponentModel.ISupportInitialize)dgvRegisteredServiceList).BeginInit();
            SuspendLayout();
            // 
            // dgvRegisteredServiceList
            // 
            dgvRegisteredServiceList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegisteredServiceList.Location = new Point(12, 12);
            dgvRegisteredServiceList.Name = "dgvRegisteredServiceList";
            dgvRegisteredServiceList.RowHeadersWidth = 51;
            dgvRegisteredServiceList.RowTemplate.Height = 29;
            dgvRegisteredServiceList.Size = new Size(646, 649);
            dgvRegisteredServiceList.TabIndex = 0;
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(dgvRegisteredServiceList);
            Name = "StaffDashboard";
            Text = "StaffDashboard";
            ((System.ComponentModel.ISupportInitialize)dgvRegisteredServiceList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRegisteredServiceList;
    }
}