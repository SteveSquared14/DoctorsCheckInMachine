
namespace MedicalCheckInSystem
{
    partial class AppChangeConf
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
            this.FinishBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FinishBtn
            // 
            this.FinishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FinishBtn.Location = new System.Drawing.Point(1052, 873);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(200, 100);
            this.FinishBtn.TabIndex = 9;
            this.FinishBtn.Text = "Finish";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label4.Location = new System.Drawing.Point(371, 546);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(581, 108);
            this.label4.TabIndex = 19;
            this.label4.Text = "this machine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label3.Location = new System.Drawing.Point(190, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(903, 108);
            this.label3.TabIndex = 18;
            this.label3.Text = "can now finish using";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label2.Location = new System.Drawing.Point(131, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1006, 108);
            this.label2.TabIndex = 17;
            this.label2.Text = "your appointment. You";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label1.Location = new System.Drawing.Point(34, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1196, 108);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thank you for rescheduling";
            // 
            // AppChangeConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinishBtn);
            this.Name = "AppChangeConf";
            this.Text = "AppChangeConf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}