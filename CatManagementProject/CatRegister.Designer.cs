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
            SuspendLayout();
            // 
            // textCatID
            // 
            textCatID.Location = new Point(563, 168);
            textCatID.Margin = new Padding(4);
            textCatID.Name = "textCatID";
            textCatID.Size = new Size(576, 29);
            textCatID.TabIndex = 0;
            // 
            // textAccountID
            // 
            textAccountID.Location = new Point(563, 238);
            textAccountID.Margin = new Padding(4);
            textAccountID.Name = "textAccountID";
            textAccountID.Size = new Size(576, 29);
            textAccountID.TabIndex = 1;
            // 
            // textBreed
            // 
            textBreed.Location = new Point(563, 307);
            textBreed.Margin = new Padding(4);
            textBreed.Name = "textBreed";
            textBreed.Size = new Size(576, 29);
            textBreed.TabIndex = 2;
            // 
            // textColor
            // 
            textColor.Location = new Point(563, 386);
            textColor.Margin = new Padding(4);
            textColor.Name = "textColor";
            textColor.Size = new Size(576, 29);
            textColor.TabIndex = 3;
            // 
            // textSex
            // 
            textSex.Location = new Point(563, 454);
            textSex.Margin = new Padding(4);
            textSex.Name = "textSex";
            textSex.Size = new Size(576, 29);
            textSex.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(328, 171);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
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
            label2.Size = new Size(81, 21);
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
            label3.Size = new Size(50, 21);
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
            label4.Size = new Size(48, 21);
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
            label5.Size = new Size(34, 21);
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
            // CatRegister
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 696);
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
            Text = "CatRegister";
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
    }
}