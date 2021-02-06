
namespace JaddinWeaponRemake1
{
    partial class SummaryWeaponPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunSummaryLabel = new System.Windows.Forms.Label();
            this.totalSummaryLabel = new System.Windows.Forms.Label();
            this.missileSummaryLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gun Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Missile Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Totals ";
            // 
            // gunSummaryLabel
            // 
            this.gunSummaryLabel.AutoSize = true;
            this.gunSummaryLabel.Location = new System.Drawing.Point(93, 53);
            this.gunSummaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunSummaryLabel.Name = "gunSummaryLabel";
            this.gunSummaryLabel.Size = new System.Drawing.Size(16, 18);
            this.gunSummaryLabel.TabIndex = 3;
            this.gunSummaryLabel.Text = "-";
            // 
            // totalSummaryLabel
            // 
            this.totalSummaryLabel.AutoSize = true;
            this.totalSummaryLabel.Location = new System.Drawing.Point(93, 226);
            this.totalSummaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalSummaryLabel.Name = "totalSummaryLabel";
            this.totalSummaryLabel.Size = new System.Drawing.Size(16, 18);
            this.totalSummaryLabel.TabIndex = 4;
            this.totalSummaryLabel.Text = "-";
            // 
            // missileSummaryLabel
            // 
            this.missileSummaryLabel.AutoSize = true;
            this.missileSummaryLabel.Location = new System.Drawing.Point(93, 142);
            this.missileSummaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.missileSummaryLabel.Name = "missileSummaryLabel";
            this.missileSummaryLabel.Size = new System.Drawing.Size(16, 18);
            this.missileSummaryLabel.TabIndex = 5;
            this.missileSummaryLabel.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.gunSummaryLabel);
            this.panel1.Controls.Add(this.totalSummaryLabel);
            this.panel1.Controls.Add(this.missileSummaryLabel);
            this.panel1.Location = new System.Drawing.Point(211, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 370);
            this.panel1.TabIndex = 6;
            // 
            // SummaryWeaponPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 363);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SummaryWeaponPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SummaryWeaponPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gunSummaryLabel;
        private System.Windows.Forms.Label totalSummaryLabel;
        private System.Windows.Forms.Label missileSummaryLabel;
        private System.Windows.Forms.Panel panel1;
    }
}