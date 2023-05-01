
namespace MedicalCheckInSystem
{
    partial class CleaningModeActivated
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label3.Location = new System.Drawing.Point(245, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(780, 108);
            this.label3.TabIndex = 18;
            this.label3.Text = "available again in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label2.Location = new System.Drawing.Point(64, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1140, 108);
            this.label2.TabIndex = 17;
            this.label2.Text = "cleaning mode and will be";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label1.Location = new System.Drawing.Point(128, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1001, 108);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sorry, this system is in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label4.Location = new System.Drawing.Point(380, 546);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 108);
            this.label4.TabIndex = 19;
            this.label4.Text = "30";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label5.Location = new System.Drawing.Point(511, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(401, 108);
            this.label5.TabIndex = 20;
            this.label5.Text = "seconds";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // CleaningModeActivated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CleaningModeActivated";
            this.Text = "CleaningModeActivated";
            this.Load += new System.EventHandler(this.CleaningModeActivated_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer2;
    }
}