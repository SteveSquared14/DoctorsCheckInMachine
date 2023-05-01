
namespace MedicalCheckInSystem
{
    partial class ChangeApp
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
            this.HomeBtn = new System.Windows.Forms.Button();
            this.ChangeAppBtn = new System.Windows.Forms.Button();
            this.ConfAppTxtBox = new System.Windows.Forms.TextBox();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HomeBtn.Location = new System.Drawing.Point(1152, 12);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(100, 100);
            this.HomeBtn.TabIndex = 5;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ChangeAppBtn
            // 
            this.ChangeAppBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.ChangeAppBtn.Location = new System.Drawing.Point(642, 573);
            this.ChangeAppBtn.Name = "ChangeAppBtn";
            this.ChangeAppBtn.Size = new System.Drawing.Size(610, 285);
            this.ChangeAppBtn.TabIndex = 12;
            this.ChangeAppBtn.Text = "Change or Cancel Appointment";
            this.ChangeAppBtn.UseVisualStyleBackColor = true;
            this.ChangeAppBtn.Click += new System.EventHandler(this.ChangeAppBtn_Click);
            // 
            // ConfAppTxtBox
            // 
            this.ConfAppTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfAppTxtBox.Location = new System.Drawing.Point(12, 273);
            this.ConfAppTxtBox.Multiline = true;
            this.ConfAppTxtBox.Name = "ConfAppTxtBox";
            this.ConfAppTxtBox.Size = new System.Drawing.Size(610, 700);
            this.ConfAppTxtBox.TabIndex = 14;
            this.ConfAppTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConfirmBtn.Location = new System.Drawing.Point(1052, 873);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(200, 100);
            this.ConfirmBtn.TabIndex = 16;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(641, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "If you would like to change or cancel your";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(641, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(618, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "appointment, please use the button below.";
            // 
            // ChangeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.ConfAppTxtBox);
            this.Controls.Add(this.ChangeAppBtn);
            this.Controls.Add(this.HomeBtn);
            this.Name = "ChangeApp";
            this.Text = "ChangeApp";
            this.Load += new System.EventHandler(this.ChangeApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button ChangeAppBtn;
        public System.Windows.Forms.TextBox ConfAppTxtBox;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}