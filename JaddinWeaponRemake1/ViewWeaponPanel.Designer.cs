
namespace JaddinWeaponRemake1
{
    partial class ViewWeaponPanel
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
            this.viewDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.viewAllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewDataGridView
            // 
            this.viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDataGridView.Location = new System.Drawing.Point(13, 101);
            this.viewDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.viewDataGridView.Name = "viewDataGridView";
            this.viewDataGridView.Size = new System.Drawing.Size(536, 375);
            this.viewDataGridView.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(19, 50);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(227, 25);
            this.searchTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weapon Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(275, 42);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(135, 41);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // viewAllButton
            // 
            this.viewAllButton.Location = new System.Drawing.Point(416, 42);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(133, 41);
            this.viewAllButton.TabIndex = 4;
            this.viewAllButton.Text = "View All";
            this.viewAllButton.UseVisualStyleBackColor = true;
            this.viewAllButton.Click += new System.EventHandler(this.viewAllButton_Click);
            // 
            // ViewWeaponPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 489);
            this.Controls.Add(this.viewAllButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.viewDataGridView);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewWeaponPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewWeaponPanel";
            this.Load += new System.EventHandler(this.ViewWeaponPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewDataGridView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button viewAllButton;
    }
}