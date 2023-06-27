namespace CatManagementProject
{
    partial class CatRegister
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
            textCatID = new TextBox();
            textAccountID = new TextBox();
            textBreed = new TextBox();
            textColor = new TextBox();
            textSex = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            RegisterButton = new Button();
            ResetButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            btnLogOut = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // textCatID
            // 
            textCatID.Location = new Point(563, 168);
            textCatID.Margin = new Padding(4);
            textCatID.Name = "textCatID";
            textCatID.Size = new Size(576, 34);
            textCatID.TabIndex = 0;
            // 
            // textAccountID
            // 
            textAccountID.Location = new Point(563, 238);
            textAccountID.Margin = new Padding(4);
            textAccountID.Name = "textAccountID";
            textAccountID.Size = new Size(576, 34);
            textAccountID.TabIndex = 1;
            // 
            // textBreed
            // 
            textBreed.Location = new Point(563, 307);
            textBreed.Margin = new Padding(4);
            textBreed.Name = "textBreed";
            textBreed.Size = new Size(576, 34);
            textBreed.TabIndex = 2;
            // 
            // textColor
            // 
            textColor.Location = new Point(563, 386);
            textColor.Margin = new Padding(4);
            textColor.Name = "textColor";
            textColor.Size = new Size(576, 34);
            textColor.TabIndex = 3;
            // 
            // textSex
            // 
            textSex.Location = new Point(563, 454);
            textSex.Margin = new Padding(4);
            textSex.Name = "textSex";
            textSex.Size = new Size(576, 34);
            textSex.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(328, 171);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 5;
            label1.Text = "CatID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(328, 241);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 6;
            label2.Text = "AccountID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(328, 315);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 28);
            label3.TabIndex = 7;
            label3.Text = "Breed";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(330, 389);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 8;
            label4.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(330, 457);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 28);
            label5.TabIndex = 9;
            label5.Text = "Sex";
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(563, 525);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(154, 47);
            RegisterButton.TabIndex = 10;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(795, 525);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(154, 47);
            ResetButton.TabIndex = 11;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
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
            flowLayoutPanel1.Size = new Size(207, 673);
            flowLayoutPanel1.TabIndex = 12;
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
            button1.Click += button1_Click;
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
            button2.Click += button2_Click;
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
            button3.Click += button3_Click;
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
            btnLogOut.Click += btnLogOut_Click;
            // 
            // CatRegister
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(ResetButton);
            Controls.Add(RegisterButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textSex);
            Controls.Add(textColor);
            Controls.Add(textBreed);
            Controls.Add(textAccountID);
            Controls.Add(textCatID);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CatRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CatRegister";
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textCatID;
        private TextBox textAccountID;
        private TextBox textBreed;
        private TextBox textColor;
        private TextBox textSex;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button RegisterButton;
        private Button ResetButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
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