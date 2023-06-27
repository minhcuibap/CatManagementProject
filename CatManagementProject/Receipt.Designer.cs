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
            dgvReceipt = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            buttonHome = new Button();
            panel3 = new Panel();
            button_Services = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button_Receipt = new Button();
            btnLogOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReceipt).BeginInit();
            flowLayoutPanel1.SuspendLayout();
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
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LimeGreen;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(btnLogOut);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(207, 597);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 75);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonHome);
            panel2.Location = new Point(3, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 65);
            panel2.TabIndex = 1;
            // 
            // buttonHome
            // 
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.Location = new Point(-21, -4);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(254, 74);
            buttonHome.TabIndex = 2;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button_Services);
            panel3.Location = new Point(3, 155);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 65);
            panel3.TabIndex = 2;
            // 
            // button_Services
            // 
            button_Services.FlatStyle = FlatStyle.Flat;
            button_Services.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_Services.Location = new Point(-21, -4);
            button_Services.Name = "button_Services";
            button_Services.Size = new Size(254, 74);
            button_Services.TabIndex = 2;
            button_Services.Text = "Services";
            button_Services.UseVisualStyleBackColor = true;
            button_Services.Click += button_Services_Click;
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
            panel5.Controls.Add(button_Receipt);
            panel5.Location = new Point(3, 297);
            panel5.Name = "panel5";
            panel5.Size = new Size(204, 65);
            panel5.TabIndex = 4;
            // 
            // button_Receipt
            // 
            button_Receipt.FlatStyle = FlatStyle.Flat;
            button_Receipt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_Receipt.Location = new Point(-21, 0);
            button_Receipt.Name = "button_Receipt";
            button_Receipt.Size = new Size(254, 74);
            button_Receipt.TabIndex = 3;
            button_Receipt.Text = "Receipt";
            button_Receipt.UseVisualStyleBackColor = true;
            button_Receipt.Click += button_Receipt_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.Location = new Point(3, 368);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(204, 74);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 597);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dgvReceipt);
            Name = "Receipt";
            Text = "Receipt";
            Load += Receipt_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReceipt).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReceipt;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button_Receipt;
        private Button btnLogOut;
        private Button buttonHome;
        private Button button_Services;
    }
}