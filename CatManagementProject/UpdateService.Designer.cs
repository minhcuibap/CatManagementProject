namespace CatManagementProject
{
    partial class UpdateService
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtErrorMsg = new Label();
            panel1 = new Panel();
            btnLogOut = new Button();
            btnServices = new Button();
            btnCat = new Button();
            btnManager = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 144);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 210);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 284);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(510, 32);
            label4.Name = "label4";
            label4.Size = new Size(245, 46);
            label4.TabIndex = 3;
            label4.Text = "Update Service";
            // 
            // txtID
            // 
            txtID.Location = new Point(448, 137);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(411, 27);
            txtID.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(448, 203);
            txtName.Name = "txtName";
            txtName.Size = new Size(411, 27);
            txtName.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(448, 277);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(411, 27);
            txtPrice.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(765, 363);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(448, 363);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtErrorMsg
            // 
            txtErrorMsg.AutoSize = true;
            txtErrorMsg.ForeColor = Color.Red;
            txtErrorMsg.Location = new Point(460, 328);
            txtErrorMsg.Name = "txtErrorMsg";
            txtErrorMsg.Size = new Size(41, 20);
            txtErrorMsg.TabIndex = 9;
            txtErrorMsg.Text = "error";
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
            panel1.TabIndex = 10;
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
            // UpdateService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel1);
            Controls.Add(txtErrorMsg);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateService";
            Text = "UpdateService";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtPrice;
        private Button btnUpdate;
        private Button btnDelete;
        private Label txtErrorMsg;
        private Panel panel1;
        private Button btnLogOut;
        private Button btnServices;
        private Button btnCat;
        private Button btnManager;
        private Panel panel2;
    }
}