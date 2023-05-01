
namespace MedicalCheckInSystem
{
    partial class WelshScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelshScreen));
            this.button1 = new System.Windows.Forms.Button();
            this.LanguageBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LanguageBtn
            // 
            this.LanguageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.LanguageBtn.Location = new System.Drawing.Point(644, 273);
            this.LanguageBtn.Name = "LanguageBtn";
            this.LanguageBtn.Size = new System.Drawing.Size(608, 700);
            this.LanguageBtn.TabIndex = 15;
            this.LanguageBtn.Text = "Dewisiadau Iaith";
            this.LanguageBtn.UseVisualStyleBackColor = true;
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.StartBtn.Location = new System.Drawing.Point(12, 273);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(620, 700);
            this.StartBtn.TabIndex = 14;
            this.StartBtn.Text = "Dechrau";
            this.StartBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label2.Location = new System.Drawing.Point(558, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 76);
            this.label2.TabIndex = 18;
            this.label2.Text = "i ddechrau.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.Location = new System.Drawing.Point(118, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 76);
            this.label1.TabIndex = 17;
            this.label1.Text = "Croeso. Dewiswch ac opsiwnwch";
            // 
            // WelshScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LanguageBtn);
            this.Controls.Add(this.StartBtn);
            this.Name = "WelshScreen";
            this.Text = "WelshScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LanguageBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}