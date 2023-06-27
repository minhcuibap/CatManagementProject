namespace CatManagementProject
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            pageSetupDialog1 = new PageSetupDialog();
            panel1 = new Panel();
            btnLogOut = new Button();
            btnServices = new Button();
            btnCat = new Button();
            btnManager = new Button();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.Location = new Point(0, 472);
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
            btnCat.Click += btnCat_Click;
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
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 125);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(459, 40);
            label1.Name = "label1";
            label1.Size = new Size(366, 31);
            label1.TabIndex = 1;
            label1.Text = "WELCOME TO MANAGER SECTION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(302, 147);
            label2.Name = "label2";
            label2.Size = new Size(316, 31);
            label2.TabIndex = 2;
            label2.Text = "Manager is for Manager Page";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(302, 319);
            label3.Name = "label3";
            label3.Size = new Size(287, 31);
            label3.TabIndex = 3;
            label3.Text = "Services to choose services";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(302, 232);
            label4.Name = "label4";
            label4.Size = new Size(239, 31);
            label4.TabIndex = 4;
            label4.Text = "Cat for managing cats";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(302, 494);
            label5.Name = "label5";
            label5.Size = new Size(202, 31);
            label5.TabIndex = 5;
            label5.Text = "Log Out to log out";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(709, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Manager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PageSetupDialog pageSetupDialog1;
        private Panel panel1;
        private Panel panel2;
        private Button btnLogOut;
        private Button btnServices;
        private Button btnCat;
        private Button btnManager;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}