
namespace JaddinWeaponRemake1
{
    partial class ControlPanel
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
            this.controlDataGridView = new System.Windows.Forms.DataGridView();
            this.showWeaponButton = new System.Windows.Forms.Button();
            this.showWeaponTypeButton = new System.Windows.Forms.Button();
            this.showWeaponRadiusButton = new System.Windows.Forms.Button();
            this.addWeaponButton = new System.Windows.Forms.Button();
            this.modifyWeaponButton = new System.Windows.Forms.Button();
            this.deleteWeaponButton = new System.Windows.Forms.Button();
            this.viewWeaponButton = new System.Windows.Forms.Button();
            this.summaryWeaponButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.controlDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlDataGridView
            // 
            this.controlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.controlDataGridView.Location = new System.Drawing.Point(177, 144);
            this.controlDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.controlDataGridView.Name = "controlDataGridView";
            this.controlDataGridView.Size = new System.Drawing.Size(515, 307);
            this.controlDataGridView.TabIndex = 0;
            this.controlDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.controlDataGridView_CellClick);
            this.controlDataGridView.DoubleClick += new System.EventHandler(this.controlDataGridView_DoubleClick);
            // 
            // showWeaponButton
            // 
            this.showWeaponButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.showWeaponButton.Location = new System.Drawing.Point(177, 81);
            this.showWeaponButton.Margin = new System.Windows.Forms.Padding(4);
            this.showWeaponButton.Name = "showWeaponButton";
            this.showWeaponButton.Size = new System.Drawing.Size(153, 55);
            this.showWeaponButton.TabIndex = 1;
            this.showWeaponButton.Text = "Show Weapon";
            this.showWeaponButton.UseVisualStyleBackColor = true;
            this.showWeaponButton.Click += new System.EventHandler(this.showWeaponButton_Click);
            // 
            // showWeaponTypeButton
            // 
            this.showWeaponTypeButton.Enabled = false;
            this.showWeaponTypeButton.Location = new System.Drawing.Point(353, 81);
            this.showWeaponTypeButton.Margin = new System.Windows.Forms.Padding(4);
            this.showWeaponTypeButton.Name = "showWeaponTypeButton";
            this.showWeaponTypeButton.Size = new System.Drawing.Size(157, 55);
            this.showWeaponTypeButton.TabIndex = 2;
            this.showWeaponTypeButton.Text = "Show Weapon Type";
            this.showWeaponTypeButton.UseVisualStyleBackColor = true;
            this.showWeaponTypeButton.Click += new System.EventHandler(this.showWeaponTypeButton_Click);
            // 
            // showWeaponRadiusButton
            // 
            this.showWeaponRadiusButton.Enabled = false;
            this.showWeaponRadiusButton.Location = new System.Drawing.Point(533, 81);
            this.showWeaponRadiusButton.Margin = new System.Windows.Forms.Padding(4);
            this.showWeaponRadiusButton.Name = "showWeaponRadiusButton";
            this.showWeaponRadiusButton.Size = new System.Drawing.Size(159, 55);
            this.showWeaponRadiusButton.TabIndex = 3;
            this.showWeaponRadiusButton.Text = "Show Weapon Radius";
            this.showWeaponRadiusButton.UseVisualStyleBackColor = true;
            this.showWeaponRadiusButton.Click += new System.EventHandler(this.showWeaponRadiusButton_Click);
            // 
            // addWeaponButton
            // 
            this.addWeaponButton.Location = new System.Drawing.Point(13, 144);
            this.addWeaponButton.Margin = new System.Windows.Forms.Padding(4);
            this.addWeaponButton.Name = "addWeaponButton";
            this.addWeaponButton.Size = new System.Drawing.Size(153, 55);
            this.addWeaponButton.TabIndex = 4;
            this.addWeaponButton.Text = "Add Weapon";
            this.addWeaponButton.UseVisualStyleBackColor = true;
            this.addWeaponButton.Click += new System.EventHandler(this.addWeaponButton_Click);
            // 
            // modifyWeaponButton
            // 
            this.modifyWeaponButton.Location = new System.Drawing.Point(13, 207);
            this.modifyWeaponButton.Margin = new System.Windows.Forms.Padding(4);
            this.modifyWeaponButton.Name = "modifyWeaponButton";
            this.modifyWeaponButton.Size = new System.Drawing.Size(153, 55);
            this.modifyWeaponButton.TabIndex = 5;
            this.modifyWeaponButton.Text = "Modify Weapon";
            this.modifyWeaponButton.UseVisualStyleBackColor = true;
            this.modifyWeaponButton.Click += new System.EventHandler(this.modifyWeaponButton_Click);
            // 
            // deleteWeaponButton
            // 
            this.deleteWeaponButton.Location = new System.Drawing.Point(13, 270);
            this.deleteWeaponButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteWeaponButton.Name = "deleteWeaponButton";
            this.deleteWeaponButton.Size = new System.Drawing.Size(153, 55);
            this.deleteWeaponButton.TabIndex = 6;
            this.deleteWeaponButton.Text = "Delete Weapon";
            this.deleteWeaponButton.UseVisualStyleBackColor = true;
            this.deleteWeaponButton.Click += new System.EventHandler(this.deleteWeaponButton_Click);
            // 
            // viewWeaponButton
            // 
            this.viewWeaponButton.Location = new System.Drawing.Point(13, 333);
            this.viewWeaponButton.Margin = new System.Windows.Forms.Padding(4);
            this.viewWeaponButton.Name = "viewWeaponButton";
            this.viewWeaponButton.Size = new System.Drawing.Size(153, 55);
            this.viewWeaponButton.TabIndex = 7;
            this.viewWeaponButton.Text = "View Weapon";
            this.viewWeaponButton.UseVisualStyleBackColor = true;
            this.viewWeaponButton.Click += new System.EventHandler(this.viewWeaponButton_Click);
            // 
            // summaryWeaponButton
            // 
            this.summaryWeaponButton.Location = new System.Drawing.Point(13, 396);
            this.summaryWeaponButton.Margin = new System.Windows.Forms.Padding(4);
            this.summaryWeaponButton.Name = "summaryWeaponButton";
            this.summaryWeaponButton.Size = new System.Drawing.Size(153, 55);
            this.summaryWeaponButton.TabIndex = 8;
            this.summaryWeaponButton.Text = "Weapon Summary";
            this.summaryWeaponButton.UseVisualStyleBackColor = true;
            this.summaryWeaponButton.Click += new System.EventHandler(this.summaryWeaponButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 59);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Weapon Control Panel";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(629, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 59);
            this.button1.TabIndex = 10;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.summaryWeaponButton);
            this.Controls.Add(this.viewWeaponButton);
            this.Controls.Add(this.deleteWeaponButton);
            this.Controls.Add(this.modifyWeaponButton);
            this.Controls.Add(this.addWeaponButton);
            this.Controls.Add(this.showWeaponRadiusButton);
            this.Controls.Add(this.showWeaponTypeButton);
            this.Controls.Add(this.showWeaponButton);
            this.Controls.Add(this.controlDataGridView);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JaddinWeaponDatabase";
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controlDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView controlDataGridView;
        private System.Windows.Forms.Button showWeaponButton;
        private System.Windows.Forms.Button showWeaponTypeButton;
        private System.Windows.Forms.Button showWeaponRadiusButton;
        private System.Windows.Forms.Button addWeaponButton;
        private System.Windows.Forms.Button modifyWeaponButton;
        private System.Windows.Forms.Button deleteWeaponButton;
        private System.Windows.Forms.Button viewWeaponButton;
        private System.Windows.Forms.Button summaryWeaponButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

