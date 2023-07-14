namespace CatManagementProject
{
    partial class CatList
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
            label1 = new Label();
            dgvCatList = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCatList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(328, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 46);
            label1.TabIndex = 0;
            label1.Text = "Cat List";
            // 
            // dgvCatList
            // 
            dgvCatList.AllowUserToAddRows = false;
            dgvCatList.AllowUserToDeleteRows = false;
            dgvCatList.AllowUserToOrderColumns = true;
            dgvCatList.AllowUserToResizeColumns = false;
            dgvCatList.AllowUserToResizeRows = false;
            dgvCatList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatList.Location = new Point(12, 58);
            dgvCatList.Name = "dgvCatList";
            dgvCatList.ReadOnly = true;
            dgvCatList.RowHeadersWidth = 51;
            dgvCatList.RowTemplate.Height = 29;
            dgvCatList.Size = new Size(758, 358);
            dgvCatList.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(676, 498);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // CatList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(btnBack);
            Controls.Add(dgvCatList);
            Controls.Add(label1);
            Name = "CatList";
            Text = "CatList";
            ((System.ComponentModel.ISupportInitialize)dgvCatList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvCatList;
        private Button btnBack;
    }
}