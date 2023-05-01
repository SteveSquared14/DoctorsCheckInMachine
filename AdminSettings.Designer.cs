
namespace MedicalCheckInSystem
{
    partial class AdminSettings
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
            this.DoBLabel = new System.Windows.Forms.Label();
            this.AdminNoTxtBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoBLabel
            // 
            this.DoBLabel.AutoSize = true;
            this.DoBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.DoBLabel.Location = new System.Drawing.Point(302, 268);
            this.DoBLabel.Name = "DoBLabel";
            this.DoBLabel.Size = new System.Drawing.Size(661, 37);
            this.DoBLabel.TabIndex = 8;
            this.DoBLabel.Text = "Click in the field below to enter your Admin ID";
            // 
            // AdminNoTxtBox
            // 
            this.AdminNoTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.AdminNoTxtBox.Location = new System.Drawing.Point(391, 308);
            this.AdminNoTxtBox.Name = "AdminNoTxtBox";
            this.AdminNoTxtBox.Size = new System.Drawing.Size(500, 44);
            this.AdminNoTxtBox.TabIndex = 9;
            this.AdminNoTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdminNoTxtBox.TextChanged += new System.EventHandler(this.AdminNoTxtBox_TextChanged);
            this.AdminNoTxtBox.GotFocus += new System.EventHandler(this.textBox_GotFocus);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BackBtn.Location = new System.Drawing.Point(12, 873);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(100, 100);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // EnterBtn
            // 
            this.EnterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EnterBtn.Location = new System.Drawing.Point(561, 358);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(200, 100);
            this.EnterBtn.TabIndex = 12;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1031, 76);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter your 6 digit Administrator ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label2.Location = new System.Drawing.Point(355, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 76);
            this.label2.TabIndex = 19;
            this.label2.Text = "into the box below.";
            // 
            // ErrorLabel1
            // 
            this.ErrorLabel1.AutoSize = true;
            this.ErrorLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ErrorLabel1.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel1.Location = new System.Drawing.Point(200, 317);
            this.ErrorLabel1.Name = "ErrorLabel1";
            this.ErrorLabel1.Size = new System.Drawing.Size(185, 29);
            this.ErrorLabel1.TabIndex = 20;
            this.ErrorLabel1.Text = "Invalid Admin ID";
            // 
            // AdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.ErrorLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AdminNoTxtBox);
            this.Controls.Add(this.DoBLabel);
            this.Name = "AdminSettings";
            this.Text = "AdminSettings";
            this.Load += new System.EventHandler(this.AdminSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DoBLabel;
        private System.Windows.Forms.TextBox AdminNoTxtBox;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorLabel1;
    }
}