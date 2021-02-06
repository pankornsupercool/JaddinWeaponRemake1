
namespace JaddinWeaponRemake1
{
    partial class AddWeaponPanel
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
            this.weaponNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radiusWeaponTextBox = new System.Windows.Forms.TextBox();
            this.detailWeaponTextBox = new System.Windows.Forms.TextBox();
            this.gunCategoryRadio = new System.Windows.Forms.RadioButton();
            this.missileCategoryRadio = new System.Windows.Forms.RadioButton();
            this.addWeaponButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weaponNameTextBox
            // 
            this.weaponNameTextBox.Location = new System.Drawing.Point(141, 30);
            this.weaponNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.weaponNameTextBox.Name = "weaponNameTextBox";
            this.weaponNameTextBox.Size = new System.Drawing.Size(321, 25);
            this.weaponNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Weapon Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "EzRadius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Datail";
            // 
            // radiusWeaponTextBox
            // 
            this.radiusWeaponTextBox.Location = new System.Drawing.Point(141, 134);
            this.radiusWeaponTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.radiusWeaponTextBox.Name = "radiusWeaponTextBox";
            this.radiusWeaponTextBox.Size = new System.Drawing.Size(321, 25);
            this.radiusWeaponTextBox.TabIndex = 6;
            // 
            // detailWeaponTextBox
            // 
            this.detailWeaponTextBox.Location = new System.Drawing.Point(141, 190);
            this.detailWeaponTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.detailWeaponTextBox.Multiline = true;
            this.detailWeaponTextBox.Name = "detailWeaponTextBox";
            this.detailWeaponTextBox.Size = new System.Drawing.Size(321, 115);
            this.detailWeaponTextBox.TabIndex = 7;
            // 
            // gunCategoryRadio
            // 
            this.gunCategoryRadio.AutoSize = true;
            this.gunCategoryRadio.Location = new System.Drawing.Point(154, 86);
            this.gunCategoryRadio.Name = "gunCategoryRadio";
            this.gunCategoryRadio.Size = new System.Drawing.Size(50, 22);
            this.gunCategoryRadio.TabIndex = 8;
            this.gunCategoryRadio.TabStop = true;
            this.gunCategoryRadio.Text = "Gun";
            this.gunCategoryRadio.UseVisualStyleBackColor = true;
            // 
            // missileCategoryRadio
            // 
            this.missileCategoryRadio.AutoSize = true;
            this.missileCategoryRadio.Location = new System.Drawing.Point(226, 86);
            this.missileCategoryRadio.Name = "missileCategoryRadio";
            this.missileCategoryRadio.Size = new System.Drawing.Size(82, 22);
            this.missileCategoryRadio.TabIndex = 9;
            this.missileCategoryRadio.TabStop = true;
            this.missileCategoryRadio.Text = "Missile";
            this.missileCategoryRadio.UseVisualStyleBackColor = true;
            // 
            // addWeaponButton
            // 
            this.addWeaponButton.Location = new System.Drawing.Point(339, 312);
            this.addWeaponButton.Name = "addWeaponButton";
            this.addWeaponButton.Size = new System.Drawing.Size(123, 50);
            this.addWeaponButton.TabIndex = 10;
            this.addWeaponButton.Text = "Add Weapon";
            this.addWeaponButton.UseVisualStyleBackColor = true;
            this.addWeaponButton.Click += new System.EventHandler(this.addWeaponButton_Click);
            // 
            // AddWeaponPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 369);
            this.Controls.Add(this.addWeaponButton);
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
            this.Name = "AddWeaponPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddWeaponPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox weaponNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox radiusWeaponTextBox;
        private System.Windows.Forms.TextBox detailWeaponTextBox;
        private System.Windows.Forms.RadioButton gunCategoryRadio;
        private System.Windows.Forms.RadioButton missileCategoryRadio;
        private System.Windows.Forms.Button addWeaponButton;
    }
}