namespace CatManagementProject
{
    partial class RegisteredServiceList
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAccountID = new TextBox();
            txtAccountFullname = new TextBox();
            txtRegisteredServiceID = new TextBox();
            label4 = new Label();
            txtServiceID = new TextBox();
            label5 = new Label();
            txtServiceName = new TextBox();
            label6 = new Label();
            txtCatID = new TextBox();
            label7 = new Label();
            txtDate = new TextBox();
            label8 = new Label();
            btnDone = new Button();
            btnCancel = new Button();
            txtStatus = new TextBox();
            label9 = new Label();
            panel1 = new Panel();
            btnLogOut = new Button();
            btnServices = new Button();
            btnCat = new Button();
            btnManager = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvRegisteredServiceList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRegisteredServiceList
            // 
            dgvRegisteredServiceList.AllowUserToAddRows = false;
            dgvRegisteredServiceList.AllowUserToResizeColumns = false;
            dgvRegisteredServiceList.AllowUserToResizeRows = false;
            dgvRegisteredServiceList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegisteredServiceList.Location = new Point(256, 58);
            dgvRegisteredServiceList.Name = "dgvRegisteredServiceList";
            dgvRegisteredServiceList.ReadOnly = true;
            dgvRegisteredServiceList.RowHeadersWidth = 51;
            dgvRegisteredServiceList.RowTemplate.Height = 29;
            dgvRegisteredServiceList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegisteredServiceList.Size = new Size(758, 235);
            dgvRegisteredServiceList.TabIndex = 0;
            dgvRegisteredServiceList.CellClick += dgvRegisteredServiceList_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(256, 9);
            label1.Name = "label1";
            label1.Size = new Size(367, 46);
            label1.TabIndex = 1;
            label1.Text = "Registered Services List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 397);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 3;
            label2.Text = "Customer ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(604, 466);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 4;
            label3.Text = "Customer Name";
            // 
            // txtAccountID
            // 
            txtAccountID.Location = new Point(375, 420);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.ReadOnly = true;
            txtAccountID.Size = new Size(150, 27);
            txtAccountID.TabIndex = 5;
            // 
            // txtAccountFullname
            // 
            txtAccountFullname.Location = new Point(604, 499);
            txtAccountFullname.Name = "txtAccountFullname";
            txtAccountFullname.ReadOnly = true;
            txtAccountFullname.Size = new Size(150, 27);
            txtAccountFullname.TabIndex = 6;
            // 
            // txtRegisteredServiceID
            // 
            txtRegisteredServiceID.Location = new Point(375, 345);
            txtRegisteredServiceID.Name = "txtRegisteredServiceID";
            txtRegisteredServiceID.ReadOnly = true;
            txtRegisteredServiceID.Size = new Size(150, 27);
            txtRegisteredServiceID.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(375, 322);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 7;
            label4.Text = "Registered Service ID";
            // 
            // txtServiceID
            // 
            txtServiceID.Location = new Point(604, 420);
            txtServiceID.Name = "txtServiceID";
            txtServiceID.ReadOnly = true;
            txtServiceID.Size = new Size(150, 27);
            txtServiceID.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(604, 397);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 9;
            label5.Text = "Service ID";
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(799, 499);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.ReadOnly = true;
            txtServiceName.Size = new Size(150, 27);
            txtServiceName.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(799, 466);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 11;
            label6.Text = "Service Name";
            // 
            // txtCatID
            // 
            txtCatID.Location = new Point(604, 345);
            txtCatID.Name = "txtCatID";
            txtCatID.ReadOnly = true;
            txtCatID.Size = new Size(150, 27);
            txtCatID.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(604, 322);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 13;
            label7.Text = "Cat ID";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(799, 345);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(150, 27);
            txtDate.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(799, 322);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 15;
            label8.Text = "Date Issued";
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.White;
            btnDone.Enabled = false;
            btnDone.Location = new Point(799, 552);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(150, 50);
            btnDone.TabIndex = 17;
            btnDone.Text = "DONE";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Enabled = false;
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(604, 552);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 50);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(799, 420);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(150, 27);
            txtStatus.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(799, 397);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 19;
            label9.Text = "Status";
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
            panel1.TabIndex = 21;
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
            // RegisteredServiceList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel1);
            Controls.Add(txtStatus);
            Controls.Add(label9);
            Controls.Add(btnCancel);
            Controls.Add(btnDone);
            Controls.Add(txtDate);
            Controls.Add(label8);
            Controls.Add(txtCatID);
            Controls.Add(label7);
            Controls.Add(txtServiceName);
            Controls.Add(label6);
            Controls.Add(txtServiceID);
            Controls.Add(label5);
            Controls.Add(txtRegisteredServiceID);
            Controls.Add(label4);
            Controls.Add(txtAccountFullname);
            Controls.Add(txtAccountID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvRegisteredServiceList);
            Name = "RegisteredServiceList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisteredServiceList";
            ((System.ComponentModel.ISupportInitialize)dgvRegisteredServiceList).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRegisteredServiceList;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAccountID;
        private TextBox txtAccountFullname;
        private TextBox txtRegisteredServiceID;
        private Label label4;
        private TextBox txtServiceID;
        private Label label5;
        private TextBox txtServiceName;
        private Label label6;
        private TextBox txtCatID;
        private Label label7;
        private TextBox txtDate;
        private Label label8;
        private Button btnDone;
        private Button btnCancel;
        private TextBox txtStatus;
        private Label label9;
        private Panel panel1;
        private Button btnLogOut;
        private Button btnServices;
        private Button btnCat;
        private Button btnManager;
        private Panel panel2;
    }
}