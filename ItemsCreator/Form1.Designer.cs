namespace ItemsCreator
{
    partial class ItemsCreator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddItem = new System.Windows.Forms.Button();
            this.tbHP = new System.Windows.Forms.TextBox();
            this.tbTextMagDamage = new System.Windows.Forms.TextBox();
            this.tbTextHP = new System.Windows.Forms.TextBox();
            this.tbMagDamage = new System.Windows.Forms.TextBox();
            this.tbTextPhysDef = new System.Windows.Forms.TextBox();
            this.tbMP = new System.Windows.Forms.TextBox();
            this.tbTextDamage = new System.Windows.Forms.TextBox();
            this.tbPhysDef = new System.Windows.Forms.TextBox();
            this.tbTextMP = new System.Windows.Forms.TextBox();
            this.tbDamage = new System.Windows.Forms.TextBox();
            this.tbTextName = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.tbTextType = new System.Windows.Forms.TextBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.tbTextClass = new System.Windows.Forms.TextBox();
            this.tbTextLvl = new System.Windows.Forms.TextBox();
            this.tbLvl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddItem.Location = new System.Drawing.Point(96, 353);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(150, 50);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbHP
            // 
            this.tbHP.Location = new System.Drawing.Point(352, 62);
            this.tbHP.Name = "tbHP";
            this.tbHP.Size = new System.Drawing.Size(100, 23);
            this.tbHP.TabIndex = 24;
            // 
            // tbTextMagDamage
            // 
            this.tbTextMagDamage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextMagDamage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextMagDamage.Location = new System.Drawing.Point(327, 282);
            this.tbTextMagDamage.Name = "tbTextMagDamage";
            this.tbTextMagDamage.ReadOnly = true;
            this.tbTextMagDamage.Size = new System.Drawing.Size(146, 26);
            this.tbTextMagDamage.TabIndex = 33;
            this.tbTextMagDamage.Text = "Magical damage";
            // 
            // tbTextHP
            // 
            this.tbTextHP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextHP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextHP.Location = new System.Drawing.Point(388, 30);
            this.tbTextHP.Name = "tbTextHP";
            this.tbTextHP.ReadOnly = true;
            this.tbTextHP.Size = new System.Drawing.Size(34, 26);
            this.tbTextHP.TabIndex = 29;
            this.tbTextHP.Text = "HP";
            // 
            // tbMagDamage
            // 
            this.tbMagDamage.Location = new System.Drawing.Point(352, 317);
            this.tbMagDamage.Name = "tbMagDamage";
            this.tbMagDamage.Size = new System.Drawing.Size(100, 23);
            this.tbMagDamage.TabIndex = 28;
            // 
            // tbTextPhysDef
            // 
            this.tbTextPhysDef.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextPhysDef.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextPhysDef.Location = new System.Drawing.Point(327, 219);
            this.tbTextPhysDef.Name = "tbTextPhysDef";
            this.tbTextPhysDef.ReadOnly = true;
            this.tbTextPhysDef.Size = new System.Drawing.Size(146, 26);
            this.tbTextPhysDef.TabIndex = 32;
            this.tbTextPhysDef.Text = "Physical defense";
            // 
            // tbMP
            // 
            this.tbMP.Location = new System.Drawing.Point(352, 125);
            this.tbMP.Name = "tbMP";
            this.tbMP.Size = new System.Drawing.Size(100, 23);
            this.tbMP.TabIndex = 25;
            // 
            // tbTextDamage
            // 
            this.tbTextDamage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextDamage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextDamage.Location = new System.Drawing.Point(367, 156);
            this.tbTextDamage.Name = "tbTextDamage";
            this.tbTextDamage.ReadOnly = true;
            this.tbTextDamage.Size = new System.Drawing.Size(79, 26);
            this.tbTextDamage.TabIndex = 31;
            this.tbTextDamage.Text = "Damage";
            // 
            // tbPhysDef
            // 
            this.tbPhysDef.Location = new System.Drawing.Point(352, 251);
            this.tbPhysDef.Name = "tbPhysDef";
            this.tbPhysDef.Size = new System.Drawing.Size(100, 23);
            this.tbPhysDef.TabIndex = 27;
            // 
            // tbTextMP
            // 
            this.tbTextMP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextMP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextMP.Location = new System.Drawing.Point(388, 93);
            this.tbTextMP.Name = "tbTextMP";
            this.tbTextMP.ReadOnly = true;
            this.tbTextMP.Size = new System.Drawing.Size(44, 26);
            this.tbTextMP.TabIndex = 30;
            this.tbTextMP.Text = "MP";
            // 
            // tbDamage
            // 
            this.tbDamage.Location = new System.Drawing.Point(352, 188);
            this.tbDamage.Name = "tbDamage";
            this.tbDamage.Size = new System.Drawing.Size(100, 23);
            this.tbDamage.TabIndex = 26;
            // 
            // tbTextName
            // 
            this.tbTextName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextName.Location = new System.Drawing.Point(12, 62);
            this.tbTextName.Name = "tbTextName";
            this.tbTextName.ReadOnly = true;
            this.tbTextName.Size = new System.Drawing.Size(62, 26);
            this.tbTextName.TabIndex = 35;
            this.tbTextName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(96, 65);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(156, 23);
            this.tbName.TabIndex = 34;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Weapon",
            "Helmet",
            "Armor"});
            this.cmbType.Location = new System.Drawing.Point(96, 125);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(156, 23);
            this.cmbType.TabIndex = 37;
            // 
            // tbTextType
            // 
            this.tbTextType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextType.Location = new System.Drawing.Point(12, 120);
            this.tbTextType.Name = "tbTextType";
            this.tbTextType.ReadOnly = true;
            this.tbTextType.Size = new System.Drawing.Size(78, 26);
            this.tbTextType.TabIndex = 36;
            this.tbTextType.Text = "Type";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "Warrior",
            "Rogue",
            "Wizard",
            "All"});
            this.cmbClass.Location = new System.Drawing.Point(96, 188);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(156, 23);
            this.cmbClass.TabIndex = 39;
            // 
            // tbTextClass
            // 
            this.tbTextClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextClass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextClass.Location = new System.Drawing.Point(12, 183);
            this.tbTextClass.Name = "tbTextClass";
            this.tbTextClass.ReadOnly = true;
            this.tbTextClass.Size = new System.Drawing.Size(78, 26);
            this.tbTextClass.TabIndex = 38;
            this.tbTextClass.Text = "Class";
            // 
            // tbTextLvl
            // 
            this.tbTextLvl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextLvl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextLvl.Location = new System.Drawing.Point(12, 248);
            this.tbTextLvl.Name = "tbTextLvl";
            this.tbTextLvl.ReadOnly = true;
            this.tbTextLvl.Size = new System.Drawing.Size(62, 26);
            this.tbTextLvl.TabIndex = 41;
            this.tbTextLvl.Text = "Lvl";
            // 
            // tbLvl
            // 
            this.tbLvl.Location = new System.Drawing.Point(96, 251);
            this.tbLvl.Name = "tbLvl";
            this.tbLvl.Size = new System.Drawing.Size(66, 23);
            this.tbLvl.TabIndex = 40;
            // 
            // ItemsCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTextLvl);
            this.Controls.Add(this.tbLvl);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.tbTextClass);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.tbTextType);
            this.Controls.Add(this.tbTextName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbHP);
            this.Controls.Add(this.tbTextMagDamage);
            this.Controls.Add(this.tbTextHP);
            this.Controls.Add(this.tbMagDamage);
            this.Controls.Add(this.tbTextPhysDef);
            this.Controls.Add(this.tbMP);
            this.Controls.Add(this.tbTextDamage);
            this.Controls.Add(this.tbPhysDef);
            this.Controls.Add(this.tbTextMP);
            this.Controls.Add(this.tbDamage);
            this.Controls.Add(this.btnAddItem);
            this.Name = "ItemsCreator";
            this.Text = "Items creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddItem;
        private TextBox tbHP;
        private TextBox tbTextMagDamage;
        private TextBox tbTextHP;
        private TextBox tbMagDamage;
        private TextBox tbTextPhysDef;
        private TextBox tbMP;
        private TextBox tbTextDamage;
        private TextBox tbPhysDef;
        private TextBox tbTextMP;
        private TextBox tbDamage;
        private TextBox tbTextName;
        private TextBox tbName;
        private ComboBox cmbType;
        private TextBox tbTextType;
        private ComboBox cmbClass;
        private TextBox tbTextClass;
        private TextBox tbTextLvl;
        private TextBox tbLvl;
    }
}