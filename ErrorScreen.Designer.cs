﻿
namespace MedicalCheckInSystem
{
    partial class ErrorScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FinishBtn
            // 
            this.FinishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FinishBtn.Location = new System.Drawing.Point(1052, 873);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(200, 100);
            this.FinishBtn.TabIndex = 7;
            this.FinishBtn.Text = "Finish";
            this.FinishBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label1.Location = new System.Drawing.Point(134, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(996, 108);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sorry, we\'re unable to ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label2.Location = new System.Drawing.Point(134, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(990, 108);
            this.label2.TabIndex = 13;
            this.label2.Text = "find your appointment.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label3.Location = new System.Drawing.Point(134, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(994, 108);
            this.label3.TabIndex = 14;
            this.label3.Text = "Please go to reception";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label4.Location = new System.Drawing.Point(149, 596);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(965, 108);
            this.label4.TabIndex = 15;
            this.label4.Text = "for further assistance.";
            // 
            // ErrorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinishBtn);
            this.Name = "ErrorScreen";
            this.Text = "ErrorScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}