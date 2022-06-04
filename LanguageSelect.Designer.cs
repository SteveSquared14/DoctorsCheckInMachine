
namespace MedicalCheckInSystem
{
    partial class LanguageSelect
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
            this.WelshBtn = new System.Windows.Forms.Button();
            this.EnglishBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelshBtn
            // 
            this.WelshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.WelshBtn.Location = new System.Drawing.Point(644, 273);
            this.WelshBtn.Name = "WelshBtn";
            this.WelshBtn.Size = new System.Drawing.Size(608, 700);
            this.WelshBtn.TabIndex = 9;
            this.WelshBtn.Text = "Cymraeg";
            this.WelshBtn.UseVisualStyleBackColor = true;
            this.WelshBtn.Click += new System.EventHandler(this.WelshBtn_Click);
            // 
            // EnglishBtn
            // 
            this.EnglishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.EnglishBtn.Location = new System.Drawing.Point(12, 273);
            this.EnglishBtn.Name = "EnglishBtn";
            this.EnglishBtn.Size = new System.Drawing.Size(620, 700);
            this.EnglishBtn.TabIndex = 8;
            this.EnglishBtn.Text = "English";
            this.EnglishBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label1.Location = new System.Drawing.Point(259, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 108);
            this.label1.TabIndex = 13;
            this.label1.Text = "Please select the";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label2.Location = new System.Drawing.Point(75, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1120, 108);
            this.label2.TabIndex = 14;
            this.label2.Text = "language you wish to use";
            // 
            // LanguageSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelshBtn);
            this.Controls.Add(this.EnglishBtn);
            this.Name = "LanguageSelect";
            this.Text = "LanguageSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WelshBtn;
        private System.Windows.Forms.Button EnglishBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}