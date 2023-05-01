﻿
namespace MedicalCheckInSystem
{
    partial class ConfirmationScreen
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
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FinishBtn
            // 
            this.FinishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FinishBtn.Location = new System.Drawing.Point(1052, 873);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(200, 100);
            this.FinishBtn.TabIndex = 8;
            this.FinishBtn.Text = "Finish";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label1.Location = new System.Drawing.Point(117, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1032, 108);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thank you for checking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label2.Location = new System.Drawing.Point(117, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1072, 108);
            this.label2.TabIndex = 12;
            this.label2.Text = "in, please take a seat in ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label3.Location = new System.Drawing.Point(74, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1115, 108);
            this.label3.TabIndex = 13;
            this.label3.Text = "the waiting area and your";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label4.Location = new System.Drawing.Point(128, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(993, 108);
            this.label4.TabIndex = 14;
            this.label4.Text = "Doctor will be with you";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label5.Location = new System.Drawing.Point(492, 669);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(354, 108);
            this.label5.TabIndex = 15;
            this.label5.Text = "shortly.";
            // 
            // ConfirmationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinishBtn);
            this.Name = "ConfirmationScreen";
            this.Text = "ConfirmationScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}