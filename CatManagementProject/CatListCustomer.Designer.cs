namespace CatManagementProject
{
    partial class CatListCustomer
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
            lbCatListCustomer = new Label();
            dgvCatListCustomer = new DataGridView();
            btnBackCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCatListCustomer).BeginInit();
            SuspendLayout();
            // 
            // lbCatListCustomer
            // 
            lbCatListCustomer.AutoSize = true;
            lbCatListCustomer.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbCatListCustomer.Location = new Point(12, 39);
            lbCatListCustomer.Name = "lbCatListCustomer";
            lbCatListCustomer.Size = new Size(114, 41);
            lbCatListCustomer.TabIndex = 0;
            lbCatListCustomer.Text = "Cat List";
            // 
            // dgvCatListCustomer
            // 
            dgvCatListCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatListCustomer.Location = new Point(12, 107);
            dgvCatListCustomer.Name = "dgvCatListCustomer";
            dgvCatListCustomer.RowHeadersWidth = 51;
            dgvCatListCustomer.RowTemplate.Height = 29;
            dgvCatListCustomer.Size = new Size(758, 345);
            dgvCatListCustomer.TabIndex = 1;
            // 
            // btnBackCustomer
            // 
            btnBackCustomer.Location = new Point(676, 482);
            btnBackCustomer.Name = "btnBackCustomer";
            btnBackCustomer.Size = new Size(94, 29);
            btnBackCustomer.TabIndex = 2;
            btnBackCustomer.Text = "BACK";
            btnBackCustomer.UseVisualStyleBackColor = true;
            btnBackCustomer.Click += btnBackCustomer_Click;
            // 
            // CatListCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(btnBackCustomer);
            Controls.Add(dgvCatListCustomer);
            Controls.Add(lbCatListCustomer);
            Name = "CatListCustomer";
            Text = "CatListCustomer";
            ((System.ComponentModel.ISupportInitialize)dgvCatListCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCatListCustomer;
        private DataGridView dgvCatListCustomer;
        private Button btnBackCustomer;
    }
}