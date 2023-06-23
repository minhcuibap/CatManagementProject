namespace CatManagementProject
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            dgvReceipt = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvReceipt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvReceipt
            // 
            dgvReceipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReceipt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvReceipt.ColumnHeadersHeight = 29;
            dgvReceipt.Location = new Point(170, -1);
            dgvReceipt.Name = "dgvReceipt";
            dgvReceipt.RowHeadersWidth = 51;
            dgvReceipt.RowTemplate.Height = 29;
            dgvReceipt.Size = new Size(1093, 298);
            dgvReceipt.TabIndex = 0;
            dgvReceipt.CellContentClick += dgvReceipt_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Location = new Point(-4, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 565);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(415, 303);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(494, 268);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 597);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(dgvReceipt);
            Name = "Receipt";
            Text = "Receipt";
            Load += Receipt_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReceipt).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReceipt;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}