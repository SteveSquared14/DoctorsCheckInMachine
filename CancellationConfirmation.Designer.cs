
namespace MedicalCheckInSystem
{
    partial class CancellationConfirmation
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label5.Location = new System.Drawing.Point(188, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(947, 108);
            this.label5.TabIndex = 20;
            this.label5.Text = "cancelled. Thank you";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label3.Location = new System.Drawing.Point(163, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(989, 108);
            this.label3.TabIndex = 18;
            this.label3.Text = "appointment has been";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label1.Location = new System.Drawing.Point(263, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 108);
            this.label1.TabIndex = 16;
            this.label1.Text = "Your appointment";
            // 
            // FinishBtn
            // 
            this.FinishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FinishBtn.Location = new System.Drawing.Point(1052, 873);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(200, 100);
            this.FinishBtn.TabIndex = 21;
            this.FinishBtn.Text = "Finish";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // CancellationConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CancellationConfirmation";
            this.Text = "CancellationConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FinishBtn;
    }
}