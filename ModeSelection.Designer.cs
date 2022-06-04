
namespace MedicalCheckInSystem
{
    partial class ModeSelection
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
            this.DoBBtn = new System.Windows.Forms.Button();
            this.NHSBtn = new System.Windows.Forms.Button();
            this.QRBtn = new System.Windows.Forms.Button();
            this.NameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HelpBtn
            // 
            this.HelpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HelpBtn.Location = new System.Drawing.Point(12, 13);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(100, 100);
            this.HelpBtn.TabIndex = 4;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HomeBtn.Location = new System.Drawing.Point(1152, 13);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(100, 100);
            this.HomeBtn.TabIndex = 5;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // DoBBtn
            // 
            this.DoBBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.DoBBtn.Location = new System.Drawing.Point(12, 273);
            this.DoBBtn.Name = "DoBBtn";
            this.DoBBtn.Size = new System.Drawing.Size(610, 345);
            this.DoBBtn.TabIndex = 6;
            this.DoBBtn.Text = "Search Date of Birth";
            this.DoBBtn.UseVisualStyleBackColor = true;
            this.DoBBtn.Click += new System.EventHandler(this.DoBBtn_Click);
            // 
            // NHSBtn
            // 
            this.NHSBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.NHSBtn.Location = new System.Drawing.Point(12, 628);
            this.NHSBtn.Name = "NHSBtn";
            this.NHSBtn.Size = new System.Drawing.Size(610, 345);
            this.NHSBtn.TabIndex = 7;
            this.NHSBtn.Text = "Search NHS Number";
            this.NHSBtn.UseVisualStyleBackColor = true;
            this.NHSBtn.Click += new System.EventHandler(this.NHSBtn_Click);
            // 
            // QRBtn
            // 
            this.QRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.QRBtn.Location = new System.Drawing.Point(642, 628);
            this.QRBtn.Name = "QRBtn";
            this.QRBtn.Size = new System.Drawing.Size(610, 345);
            this.QRBtn.TabIndex = 8;
            this.QRBtn.Text = "Scan QR Code";
            this.QRBtn.UseVisualStyleBackColor = true;
            this.QRBtn.Click += new System.EventHandler(this.QRBtn_Click);
            // 
            // NameBtn
            // 
            this.NameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.NameBtn.Location = new System.Drawing.Point(642, 273);
            this.NameBtn.Name = "NameBtn";
            this.NameBtn.Size = new System.Drawing.Size(610, 345);
            this.NameBtn.TabIndex = 9;
            this.NameBtn.Text = "Search Name";
            this.NameBtn.UseVisualStyleBackColor = true;
            this.NameBtn.Click += new System.EventHandler(this.NameBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.Location = new System.Drawing.Point(118, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1017, 76);
            this.label1.TabIndex = 14;
            this.label1.Text = "Please select the option you wish";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label2.Location = new System.Drawing.Point(518, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 76);
            this.label2.TabIndex = 15;
            this.label2.Text = "to use.";
            // 
            // ModeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBtn);
            this.Controls.Add(this.QRBtn);
            this.Controls.Add(this.NHSBtn);
            this.Controls.Add(this.DoBBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.HelpBtn);
            this.Name = "ModeSelection";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button DoBBtn;
        private System.Windows.Forms.Button NHSBtn;
        private System.Windows.Forms.Button QRBtn;
        private System.Windows.Forms.Button NameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}