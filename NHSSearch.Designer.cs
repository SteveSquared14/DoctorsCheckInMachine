
namespace MedicalCheckInSystem
{
    partial class NHSSearch
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
            this.HelpBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.NHSLabel = new System.Windows.Forms.Label();
            this.NHSNumberTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HelpBtn
            // 
            this.HelpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HelpBtn.Location = new System.Drawing.Point(12, 12);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(100, 100);
            this.HelpBtn.TabIndex = 1;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HomeBtn.Location = new System.Drawing.Point(1152, 12);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(100, 100);
            this.HomeBtn.TabIndex = 2;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BackBtn.Location = new System.Drawing.Point(12, 873);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(100, 100);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // EnterBtn
            // 
            this.EnterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EnterBtn.Location = new System.Drawing.Point(1052, 873);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(200, 100);
            this.EnterBtn.TabIndex = 6;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click_1);
            // 
            // NHSLabel
            // 
            this.NHSLabel.AutoSize = true;
            this.NHSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.NHSLabel.Location = new System.Drawing.Point(289, 269);
            this.NHSLabel.Name = "NHSLabel";
            this.NHSLabel.Size = new System.Drawing.Size(721, 37);
            this.NHSLabel.TabIndex = 9;
            this.NHSLabel.Text = "Click in the field below to enter your NHS Number";
            // 
            // NHSNumberTxtBox
            // 
            this.NHSNumberTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.NHSNumberTxtBox.Location = new System.Drawing.Point(402, 309);
            this.NHSNumberTxtBox.Name = "NHSNumberTxtBox";
            this.NHSNumberTxtBox.Size = new System.Drawing.Size(500, 44);
            this.NHSNumberTxtBox.TabIndex = 8;
            this.NHSNumberTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NHSNumberTxtBox.GotFocus += new System.EventHandler(this.textBox_GotFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.Location = new System.Drawing.Point(146, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(969, 76);
            this.label1.TabIndex = 16;
            this.label1.Text = "Please enter your NHS Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label2.Location = new System.Drawing.Point(371, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 76);
            this.label2.TabIndex = 17;
            this.label2.Text = "into the field below.";
            // 
            // ErrorLabel1
            // 
            this.ErrorLabel1.AutoSize = true;
            this.ErrorLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ErrorLabel1.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel1.Location = new System.Drawing.Point(273, 318);
            this.ErrorLabel1.Name = "ErrorLabel1";
            this.ErrorLabel1.Size = new System.Drawing.Size(123, 29);
            this.ErrorLabel1.TabIndex = 19;
            this.ErrorLabel1.Text = "Required*";
            // 
            // NHSSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.ErrorLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NHSLabel);
            this.Controls.Add(this.NHSNumberTxtBox);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.HelpBtn);
            this.Name = "NHSSearch";
            this.Text = "NHSSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Label NHSLabel;
        private System.Windows.Forms.TextBox NHSNumberTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorLabel1;
    }
}