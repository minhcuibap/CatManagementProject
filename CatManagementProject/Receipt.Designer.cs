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
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            buttonReceipt = new Button();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            btnLogOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReceipt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReceipt
            // 
            dgvReceipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReceipt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvReceipt.ColumnHeadersHeight = 29;
            dgvReceipt.Location = new Point(188, -1);
            dgvReceipt.Name = "dgvReceipt";
            dgvReceipt.RowHeadersWidth = 51;
            dgvReceipt.RowTemplate.Height = 29;
            dgvReceipt.Size = new Size(1075, 298);
            dgvReceipt.TabIndex = 0;
            dgvReceipt.CellContentClick += dgvReceipt_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(355, 296);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(494, 268);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LimeGreen;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(207, 597);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonReceipt);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 75);
            panel1.TabIndex = 1;
            // 
            // buttonReceipt
            // 
            buttonReceipt.FlatStyle = FlatStyle.Flat;
            buttonReceipt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReceipt.Location = new Point(-21, 9);
            buttonReceipt.Name = "buttonReceipt";
            buttonReceipt.Size = new Size(254, 74);
            buttonReceipt.TabIndex = 3;
            buttonReceipt.Text = "Receipt";
            buttonReceipt.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 65);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(-21, -4);
            button1.Name = "button1";
            button1.Size = new Size(254, 74);
            button1.TabIndex = 2;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonHome_click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 155);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 65);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(-21, -4);
            button2.Name = "button2";
            button2.Size = new Size(254, 74);
            button2.TabIndex = 2;
            button2.Text = "Services";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 226);
            panel4.Name = "panel4";
            panel4.Size = new Size(204, 65);
            panel4.TabIndex = 3;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(-21, -4);
            button3.Name = "button3";
            button3.Size = new Size(254, 74);
            button3.TabIndex = 2;
            button3.Text = "Cat List";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnLogOut);
            panel5.Location = new Point(3, 297);
            panel5.Name = "panel5";
            panel5.Size = new Size(204, 65);
            panel5.TabIndex = 4;
            // 
            // btnLogOut
            // 
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.Location = new Point(-21, -4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(254, 74);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 597);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvReceipt);
            Name = "Receipt";
            Text = "Receipt";
            Load += Receipt_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReceipt).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReceipt;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button buttonReceipt;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button btnLogOut;
    }
}