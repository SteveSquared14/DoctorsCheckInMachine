
namespace MedicalCheckInSystem
{
    partial class DOBSearch
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
            this.DoBTxtBox = new System.Windows.Forms.TextBox();
            this.DoBLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.BackBtn.TabIndex = 4;
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
            this.EnterBtn.TabIndex = 5;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // DoBTxtBox
            // 
            this.DoBTxtBox.BackColor = System.Drawing.Color.White;
            this.DoBTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.DoBTxtBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DoBTxtBox.Location = new System.Drawing.Point(398, 340);
            this.DoBTxtBox.Name = "DoBTxtBox";
            this.DoBTxtBox.Size = new System.Drawing.Size(500, 44);
            this.DoBTxtBox.TabIndex = 6;
            this.DoBTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DoBTxtBox.GotFocus += new System.EventHandler(this.textBox_GotFocus);
            // 
            // DoBLabel
            // 
            this.DoBLabel.AutoSize = true;
            this.DoBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.DoBLabel.Location = new System.Drawing.Point(342, 300);
            this.DoBLabel.Name = "DoBLabel";
            this.DoBLabel.Size = new System.Drawing.Size(609, 37);
            this.DoBLabel.TabIndex = 7;
            this.DoBLabel.Text = "Click in the field below to enter your D.o.B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.Location = new System.Drawing.Point(136, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(993, 76);
            this.label1.TabIndex = 15;
            this.label1.Text = "Please enter your date of birth in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label2.Location = new System.Drawing.Point(222, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(844, 76);
            this.label2.TabIndex = 16;
            this.label2.Text = "the field below in the format";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label3.Location = new System.Drawing.Point(452, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 76);
            this.label3.TabIndex = 17;
            this.label3.Text = "DDMMYYYY";
            // 
            // ErrorLabel1
            // 
            this.ErrorLabel1.AutoSize = true;
            this.ErrorLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ErrorLabel1.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel1.Location = new System.Drawing.Point(269, 349);
            this.ErrorLabel1.Name = "ErrorLabel1";
            this.ErrorLabel1.Size = new System.Drawing.Size(123, 29);
            this.ErrorLabel1.TabIndex = 18;
            this.ErrorLabel1.Text = "Required*";
            // 
            // DOBSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.ErrorLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoBLabel);
            this.Controls.Add(this.DoBTxtBox);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.HelpBtn);
            this.Name = "DOBSearch";
            this.Text = "DOBSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.TextBox DoBTxtBox;
        private System.Windows.Forms.Label DoBLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ErrorLabel1;
    }
}