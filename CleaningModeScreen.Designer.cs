
namespace MedicalCheckInSystem
{
    partial class CleaningModeScreen
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CleaningModeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label3.Location = new System.Drawing.Point(554, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 76);
            this.label3.TabIndex = 21;
            this.label3.Text = "below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label2.Location = new System.Drawing.Point(155, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(981, 76);
            this.label2.TabIndex = 20;
            this.label2.Text = "cleaning mode, press the button";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.Location = new System.Drawing.Point(161, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(964, 76);
            this.label1.TabIndex = 19;
            this.label1.Text = "To disable the machine to enter";
            // 
            // CleaningModeBtn
            // 
            this.CleaningModeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CleaningModeBtn.Location = new System.Drawing.Point(560, 444);
            this.CleaningModeBtn.Name = "CleaningModeBtn";
            this.CleaningModeBtn.Size = new System.Drawing.Size(200, 100);
            this.CleaningModeBtn.TabIndex = 22;
            this.CleaningModeBtn.Text = "Enter Cleaning Mode";
            this.CleaningModeBtn.UseVisualStyleBackColor = true;
            this.CleaningModeBtn.Click += new System.EventHandler(this.CleaningModeBtn_Click);
            // 
            // CleaningModeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.CleaningModeBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CleaningModeScreen";
            this.Text = "CleaningModeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CleaningModeBtn;
    }
}