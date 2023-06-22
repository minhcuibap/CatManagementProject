namespace CatManagementProject
{
    partial class CreateService
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
            btnCreate = new Button();
            txtErrorMsg = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 142);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 206);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 274);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(245, 42);
            label4.Name = "label4";
            label4.Size = new Size(310, 46);
            label4.TabIndex = 3;
            label4.Text = "Create New Service";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(245, 139);
            txtID.Name = "txtID";
            txtID.Size = new Size(430, 27);
            txtID.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(245, 203);
            txtName.Name = "txtName";
            txtName.Size = new Size(430, 27);
            txtName.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(245, 271);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(430, 27);
            txtPrice.TabIndex = 6;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(581, 338);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtErrorMsg
            // 
            txtErrorMsg.AutoSize = true;
            txtErrorMsg.ForeColor = Color.Red;
            txtErrorMsg.Location = new Point(245, 342);
            txtErrorMsg.Name = "txtErrorMsg";
            txtErrorMsg.Size = new Size(41, 20);
            txtErrorMsg.TabIndex = 8;
            txtErrorMsg.Text = "error";
            // 
            // CreateService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtErrorMsg);
            Controls.Add(btnCreate);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateService";
            Text = "CreateService";
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
        private Button btnCreate;
        private Label txtErrorMsg;
    }
}