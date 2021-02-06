
namespace JaddinWeaponRemake1
{
    partial class ModifyWeaponPanel
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
            this.modifyWeaponButton = new System.Windows.Forms.Button();
            this.missileCategoryRadio = new System.Windows.Forms.RadioButton();
            this.gunCategoryRadio = new System.Windows.Forms.RadioButton();
            this.detailWeaponTextBox = new System.Windows.Forms.TextBox();
            this.radiusWeaponTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.weaponNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // modifyWeaponButton
            // 
            this.modifyWeaponButton.Enabled = false;
            this.modifyWeaponButton.Location = new System.Drawing.Point(339, 311);
            this.modifyWeaponButton.Name = "modifyWeaponButton";
            this.modifyWeaponButton.Size = new System.Drawing.Size(123, 50);
            this.modifyWeaponButton.TabIndex = 20;
            this.modifyWeaponButton.Text = "Modify Weapon";
            this.modifyWeaponButton.UseVisualStyleBackColor = true;
            this.modifyWeaponButton.Click += new System.EventHandler(this.addWeaponButton_Click);
            // 
            // missileCategoryRadio
            // 
            this.missileCategoryRadio.AutoSize = true;
            this.missileCategoryRadio.Enabled = false;
            this.missileCategoryRadio.Location = new System.Drawing.Point(226, 85);
            this.missileCategoryRadio.Name = "missileCategoryRadio";
            this.missileCategoryRadio.Size = new System.Drawing.Size(82, 22);
            this.missileCategoryRadio.TabIndex = 19;
            this.missileCategoryRadio.TabStop = true;
            this.missileCategoryRadio.Text = "Missile";
            this.missileCategoryRadio.UseVisualStyleBackColor = true;
            // 
            // gunCategoryRadio
            // 
            this.gunCategoryRadio.AutoSize = true;
            this.gunCategoryRadio.Enabled = false;
            this.gunCategoryRadio.Location = new System.Drawing.Point(154, 85);
            this.gunCategoryRadio.Name = "gunCategoryRadio";
            this.gunCategoryRadio.Size = new System.Drawing.Size(50, 22);
            this.gunCategoryRadio.TabIndex = 18;
            this.gunCategoryRadio.TabStop = true;
            this.gunCategoryRadio.Text = "Gun";
            this.gunCategoryRadio.UseVisualStyleBackColor = true;
            // 
            // detailWeaponTextBox
            // 
            this.detailWeaponTextBox.Enabled = false;
            this.detailWeaponTextBox.Location = new System.Drawing.Point(141, 189);
            this.detailWeaponTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.detailWeaponTextBox.Multiline = true;
            this.detailWeaponTextBox.Name = "detailWeaponTextBox";
            this.detailWeaponTextBox.Size = new System.Drawing.Size(321, 115);
            this.detailWeaponTextBox.TabIndex = 17;
            // 
            // radiusWeaponTextBox
            // 
            this.radiusWeaponTextBox.Enabled = false;
            this.radiusWeaponTextBox.Location = new System.Drawing.Point(141, 133);
            this.radiusWeaponTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.radiusWeaponTextBox.Name = "radiusWeaponTextBox";
            this.radiusWeaponTextBox.Size = new System.Drawing.Size(321, 25);
            this.radiusWeaponTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Datail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "EzRadius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Weapon Name";
            // 
            // weaponNameTextBox
            // 
            this.weaponNameTextBox.Enabled = false;
            this.weaponNameTextBox.Location = new System.Drawing.Point(141, 29);
            this.weaponNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.weaponNameTextBox.Name = "weaponNameTextBox";
            this.weaponNameTextBox.Size = new System.Drawing.Size(321, 25);
            this.weaponNameTextBox.TabIndex = 11;
            // 
            // ModifyWeaponPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 369);
            this.Controls.Add(this.modifyWeaponButton);
            this.Controls.Add(this.missileCategoryRadio);
            this.Controls.Add(this.gunCategoryRadio);
            this.Controls.Add(this.detailWeaponTextBox);
            this.Controls.Add(this.radiusWeaponTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weaponNameTextBox);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModifyWeaponPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyWeaponPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifyWeaponButton;
        private System.Windows.Forms.RadioButton missileCategoryRadio;
        private System.Windows.Forms.RadioButton gunCategoryRadio;
        private System.Windows.Forms.TextBox detailWeaponTextBox;
        private System.Windows.Forms.TextBox radiusWeaponTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox weaponNameTextBox;
    }
}