namespace CatManagementProject
{
    partial class AccountManager
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
            dgvUser = new DataGridView();
            cbFilterBy = new ComboBox();
            label1 = new Label();
            btnFilter = new Button();
            txtAccountID = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnUpdateStatus = new Button();
            txtStatus = new TextBox();
            label4 = new Label();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(12, 13);
            dgvUser.Margin = new Padding(3, 4, 3, 4);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersWidth = 51;
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(758, 263);
            dgvUser.TabIndex = 0;
            dgvUser.CellDoubleClick += dgvUser_CellDoubleClick;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Location = new Point(33, 317);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(151, 28);
            cbFilterBy.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 289);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 2;
            label1.Text = "Filter by";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(64, 351);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(79, 29);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // txtAccountID
            // 
            txtAccountID.Location = new Point(301, 318);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(125, 27);
            txtAccountID.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(463, 318);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(313, 289);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 6;
            label2.Text = "AccountID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(479, 289);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 7;
            label3.Text = "Username";
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(463, 351);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(125, 29);
            btnUpdateStatus.TabIndex = 8;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(625, 318);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(125, 27);
            txtStatus.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(657, 289);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 10;
            label4.Text = "Status";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(288, 412);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(162, 64);
            btnReset.TabIndex = 11;
            btnReset.Text = "RESET ALL";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // AccountManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(btnReset);
            Controls.Add(label4);
            Controls.Add(txtStatus);
            Controls.Add(btnUpdateStatus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(txtAccountID);
            Controls.Add(btnFilter);
            Controls.Add(label1);
            Controls.Add(cbFilterBy);
            Controls.Add(dgvUser);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AccountManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserList";
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUser;
        private ComboBox cbFilterBy;
        private Label label1;
        private Button btnFilter;
        private TextBox txtAccountID;
        private TextBox txtUsername;
        private Label label2;
        private Label label3;
        private Button btnUpdateStatus;
        private TextBox txtStatus;
        private Label label4;
        private Button btnReset;
    }
}