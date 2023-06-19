namespace CatManagementProject
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            txtUsername = new TextBox();
            txtFullname = new TextBox();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            lable1 = new Label();
            btnCreate = new Button();
            btnReset = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(162, 110);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(313, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(162, 271);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(313, 27);
            txtFullname.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(162, 162);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(313, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(162, 215);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(313, 27);
            txtConfirm.TabIndex = 2;
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lable1.Location = new Point(63, 9);
            lable1.Name = "lable1";
            lable1.Size = new Size(412, 60);
            lable1.TabIndex = 4;
            lable1.Text = "Register an Account";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(192, 347);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Register";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(354, 347);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 110);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 162);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 215);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 9;
            label1.Text = "Confirm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(32, 271);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 10;
            label4.Text = "Fullname";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(29, 351);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(111, 20);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Return to Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(532, 402);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(532, 403);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnReset);
            Controls.Add(btnCreate);
            Controls.Add(lable1);
            Controls.Add(txtConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtFullname);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtFullname;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private Label lable1;
        private Button btnCreate;
        private Button btnReset;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}