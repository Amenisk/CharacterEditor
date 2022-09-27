namespace CharacterEditor
{
    partial class CharacterEditor
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
            this.lbCharacters = new System.Windows.Forms.ListBox();
            this.tbStrength = new System.Windows.Forms.TextBox();
            this.tbDexterity = new System.Windows.Forms.TextBox();
            this.tbConstitution = new System.Windows.Forms.TextBox();
            this.tbInteligence = new System.Windows.Forms.TextBox();
            this.btnCreateCharacter = new System.Windows.Forms.Button();
            this.tbHP = new System.Windows.Forms.TextBox();
            this.tbMP = new System.Windows.Forms.TextBox();
            this.tbDamage = new System.Windows.Forms.TextBox();
            this.tbPhysDef = new System.Windows.Forms.TextBox();
            this.tbMagDamage = new System.Windows.Forms.TextBox();
            this.btnIncreaseStrength = new System.Windows.Forms.Button();
            this.btnIncreaseDexterity = new System.Windows.Forms.Button();
            this.btnIncreaseConstitution = new System.Windows.Forms.Button();
            this.btnIncreaseInteligence = new System.Windows.Forms.Button();
            this.tbCountOfPoints = new System.Windows.Forms.TextBox();
            this.btnSaveCharacter = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tbSelectFromList = new System.Windows.Forms.TextBox();
            this.cmbNames = new System.Windows.Forms.ComboBox();
            this.tbTextName = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTextNumberOfPoints = new System.Windows.Forms.TextBox();
            this.tbTextInteligence = new System.Windows.Forms.TextBox();
            this.tbTextConstitution = new System.Windows.Forms.TextBox();
            this.tbTextDexterity = new System.Windows.Forms.TextBox();
            this.tbTextStrength = new System.Windows.Forms.TextBox();
            this.tbChooseCharacter = new System.Windows.Forms.TextBox();
            this.tbTextHP = new System.Windows.Forms.TextBox();
            this.tbTextMP = new System.Windows.Forms.TextBox();
            this.tbTextDamage = new System.Windows.Forms.TextBox();
            this.tbTextPhysDef = new System.Windows.Forms.TextBox();
            this.tbTextMagDamage = new System.Windows.Forms.TextBox();
            this.pnlCharacteristics = new System.Windows.Forms.Panel();
            this.tbInventory = new System.Windows.Forms.TextBox();
            this.cmbInventory = new System.Windows.Forms.ComboBox();
            this.tbAddItem = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlCharacteristics.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCharacters
            // 
            this.lbCharacters.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCharacters.FormattingEnabled = true;
            this.lbCharacters.ItemHeight = 32;
            this.lbCharacters.Items.AddRange(new object[] {
            "Warrior",
            "Rogue",
            "Wizard"});
            this.lbCharacters.Location = new System.Drawing.Point(192, 62);
            this.lbCharacters.Name = "lbCharacters";
            this.lbCharacters.Size = new System.Drawing.Size(90, 100);
            this.lbCharacters.TabIndex = 0;
            this.lbCharacters.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbStrength
            // 
            this.tbStrength.Location = new System.Drawing.Point(167, 290);
            this.tbStrength.Name = "tbStrength";
            this.tbStrength.ReadOnly = true;
            this.tbStrength.Size = new System.Drawing.Size(100, 25);
            this.tbStrength.TabIndex = 1;
            // 
            // tbDexterity
            // 
            this.tbDexterity.Location = new System.Drawing.Point(167, 323);
            this.tbDexterity.Name = "tbDexterity";
            this.tbDexterity.ReadOnly = true;
            this.tbDexterity.Size = new System.Drawing.Size(100, 25);
            this.tbDexterity.TabIndex = 2;
            // 
            // tbConstitution
            // 
            this.tbConstitution.Location = new System.Drawing.Point(167, 356);
            this.tbConstitution.Name = "tbConstitution";
            this.tbConstitution.ReadOnly = true;
            this.tbConstitution.Size = new System.Drawing.Size(100, 25);
            this.tbConstitution.TabIndex = 3;
            // 
            // tbInteligence
            // 
            this.tbInteligence.Location = new System.Drawing.Point(167, 387);
            this.tbInteligence.Name = "tbInteligence";
            this.tbInteligence.ReadOnly = true;
            this.tbInteligence.Size = new System.Drawing.Size(100, 25);
            this.tbInteligence.TabIndex = 4;
            // 
            // btnCreateCharacter
            // 
            this.btnCreateCharacter.Location = new System.Drawing.Point(192, 430);
            this.btnCreateCharacter.Name = "btnCreateCharacter";
            this.btnCreateCharacter.Size = new System.Drawing.Size(75, 26);
            this.btnCreateCharacter.TabIndex = 5;
            this.btnCreateCharacter.Text = "Create";
            this.btnCreateCharacter.UseVisualStyleBackColor = true;
            this.btnCreateCharacter.Click += new System.EventHandler(this.btnCreateCharacter_Click);
            // 
            // tbHP
            // 
            this.tbHP.Location = new System.Drawing.Point(114, 91);
            this.tbHP.Name = "tbHP";
            this.tbHP.ReadOnly = true;
            this.tbHP.Size = new System.Drawing.Size(100, 25);
            this.tbHP.TabIndex = 6;
            // 
            // tbMP
            // 
            this.tbMP.Location = new System.Drawing.Point(114, 154);
            this.tbMP.Name = "tbMP";
            this.tbMP.ReadOnly = true;
            this.tbMP.Size = new System.Drawing.Size(100, 25);
            this.tbMP.TabIndex = 7;
            // 
            // tbDamage
            // 
            this.tbDamage.Location = new System.Drawing.Point(114, 217);
            this.tbDamage.Name = "tbDamage";
            this.tbDamage.ReadOnly = true;
            this.tbDamage.Size = new System.Drawing.Size(100, 25);
            this.tbDamage.TabIndex = 8;
            // 
            // tbPhysDef
            // 
            this.tbPhysDef.Location = new System.Drawing.Point(114, 280);
            this.tbPhysDef.Name = "tbPhysDef";
            this.tbPhysDef.ReadOnly = true;
            this.tbPhysDef.Size = new System.Drawing.Size(100, 25);
            this.tbPhysDef.TabIndex = 9;
            // 
            // tbMagDamage
            // 
            this.tbMagDamage.Location = new System.Drawing.Point(114, 346);
            this.tbMagDamage.Name = "tbMagDamage";
            this.tbMagDamage.ReadOnly = true;
            this.tbMagDamage.Size = new System.Drawing.Size(100, 25);
            this.tbMagDamage.TabIndex = 10;
            // 
            // btnIncreaseStrength
            // 
            this.btnIncreaseStrength.Location = new System.Drawing.Point(273, 292);
            this.btnIncreaseStrength.Name = "btnIncreaseStrength";
            this.btnIncreaseStrength.Size = new System.Drawing.Size(23, 23);
            this.btnIncreaseStrength.TabIndex = 11;
            this.btnIncreaseStrength.Text = "+";
            this.btnIncreaseStrength.UseVisualStyleBackColor = true;
            this.btnIncreaseStrength.Click += new System.EventHandler(this.btnIncreaseStrength_Click);
            // 
            // btnIncreaseDexterity
            // 
            this.btnIncreaseDexterity.Location = new System.Drawing.Point(273, 325);
            this.btnIncreaseDexterity.Name = "btnIncreaseDexterity";
            this.btnIncreaseDexterity.Size = new System.Drawing.Size(23, 23);
            this.btnIncreaseDexterity.TabIndex = 12;
            this.btnIncreaseDexterity.Text = "+";
            this.btnIncreaseDexterity.UseVisualStyleBackColor = true;
            this.btnIncreaseDexterity.Click += new System.EventHandler(this.btnIncreaseDexterity_Click);
            // 
            // btnIncreaseConstitution
            // 
            this.btnIncreaseConstitution.Location = new System.Drawing.Point(273, 356);
            this.btnIncreaseConstitution.Name = "btnIncreaseConstitution";
            this.btnIncreaseConstitution.Size = new System.Drawing.Size(23, 23);
            this.btnIncreaseConstitution.TabIndex = 13;
            this.btnIncreaseConstitution.Text = "+";
            this.btnIncreaseConstitution.UseVisualStyleBackColor = true;
            this.btnIncreaseConstitution.Click += new System.EventHandler(this.btnIncreaseConstitution_Click);
            // 
            // btnIncreaseInteligence
            // 
            this.btnIncreaseInteligence.Location = new System.Drawing.Point(273, 387);
            this.btnIncreaseInteligence.Name = "btnIncreaseInteligence";
            this.btnIncreaseInteligence.Size = new System.Drawing.Size(23, 23);
            this.btnIncreaseInteligence.TabIndex = 14;
            this.btnIncreaseInteligence.Text = "+";
            this.btnIncreaseInteligence.UseVisualStyleBackColor = true;
            this.btnIncreaseInteligence.Click += new System.EventHandler(this.btnIncreaseInteligence_Click);
            // 
            // tbCountOfPoints
            // 
            this.tbCountOfPoints.Location = new System.Drawing.Point(257, 245);
            this.tbCountOfPoints.Name = "tbCountOfPoints";
            this.tbCountOfPoints.ReadOnly = true;
            this.tbCountOfPoints.Size = new System.Drawing.Size(25, 25);
            this.tbCountOfPoints.TabIndex = 15;
            // 
            // btnSaveCharacter
            // 
            this.btnSaveCharacter.Location = new System.Drawing.Point(51, 433);
            this.btnSaveCharacter.Name = "btnSaveCharacter";
            this.btnSaveCharacter.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCharacter.TabIndex = 16;
            this.btnSaveCharacter.Text = "Save";
            this.btnSaveCharacter.UseVisualStyleBackColor = true;
            this.btnSaveCharacter.Click += new System.EventHandler(this.btnSaveCharacter_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tbSelectFromList);
            this.pnlMain.Controls.Add(this.cmbNames);
            this.pnlMain.Controls.Add(this.tbTextName);
            this.pnlMain.Controls.Add(this.tbName);
            this.pnlMain.Controls.Add(this.tbTextNumberOfPoints);
            this.pnlMain.Controls.Add(this.tbTextInteligence);
            this.pnlMain.Controls.Add(this.tbTextConstitution);
            this.pnlMain.Controls.Add(this.tbCountOfPoints);
            this.pnlMain.Controls.Add(this.tbTextDexterity);
            this.pnlMain.Controls.Add(this.tbTextStrength);
            this.pnlMain.Controls.Add(this.tbChooseCharacter);
            this.pnlMain.Controls.Add(this.tbStrength);
            this.pnlMain.Controls.Add(this.btnSaveCharacter);
            this.pnlMain.Controls.Add(this.tbDexterity);
            this.pnlMain.Controls.Add(this.tbConstitution);
            this.pnlMain.Controls.Add(this.btnIncreaseInteligence);
            this.pnlMain.Controls.Add(this.tbInteligence);
            this.pnlMain.Controls.Add(this.btnIncreaseConstitution);
            this.pnlMain.Controls.Add(this.btnIncreaseStrength);
            this.pnlMain.Controls.Add(this.btnIncreaseDexterity);
            this.pnlMain.Controls.Add(this.lbCharacters);
            this.pnlMain.Controls.Add(this.btnCreateCharacter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(333, 510);
            this.pnlMain.TabIndex = 17;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // tbSelectFromList
            // 
            this.tbSelectFromList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSelectFromList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSelectFromList.Location = new System.Drawing.Point(18, 11);
            this.tbSelectFromList.Name = "tbSelectFromList";
            this.tbSelectFromList.ReadOnly = true;
            this.tbSelectFromList.Size = new System.Drawing.Size(143, 26);
            this.tbSelectFromList.TabIndex = 29;
            this.tbSelectFromList.Text = "Select from list";
            // 
            // cmbNames
            // 
            this.cmbNames.FormattingEnabled = true;
            this.cmbNames.Location = new System.Drawing.Point(167, 12);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(156, 25);
            this.cmbNames.TabIndex = 28;
            this.cmbNames.SelectedIndexChanged += new System.EventHandler(this.cmbNames_SelectedIndexChanged);
            this.cmbNames.SelectedValueChanged += new System.EventHandler(this.cmbNames_SelectedValueChanged);
            // 
            // tbTextName
            // 
            this.tbTextName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextName.Location = new System.Drawing.Point(51, 195);
            this.tbTextName.Name = "tbTextName";
            this.tbTextName.ReadOnly = true;
            this.tbTextName.Size = new System.Drawing.Size(102, 26);
            this.tbTextName.TabIndex = 27;
            this.tbTextName.Text = "Enter name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(167, 195);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(156, 25);
            this.tbName.TabIndex = 26;
            // 
            // tbTextNumberOfPoints
            // 
            this.tbTextNumberOfPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextNumberOfPoints.Location = new System.Drawing.Point(141, 248);
            this.tbTextNumberOfPoints.Name = "tbTextNumberOfPoints";
            this.tbTextNumberOfPoints.ReadOnly = true;
            this.tbTextNumberOfPoints.Size = new System.Drawing.Size(110, 18);
            this.tbTextNumberOfPoints.TabIndex = 25;
            this.tbTextNumberOfPoints.Text = "Number of points";
            // 
            // tbTextInteligence
            // 
            this.tbTextInteligence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextInteligence.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextInteligence.Location = new System.Drawing.Point(51, 387);
            this.tbTextInteligence.Name = "tbTextInteligence";
            this.tbTextInteligence.ReadOnly = true;
            this.tbTextInteligence.Size = new System.Drawing.Size(110, 26);
            this.tbTextInteligence.TabIndex = 21;
            this.tbTextInteligence.Text = "Inteligence";
            // 
            // tbTextConstitution
            // 
            this.tbTextConstitution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextConstitution.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextConstitution.Location = new System.Drawing.Point(51, 356);
            this.tbTextConstitution.Name = "tbTextConstitution";
            this.tbTextConstitution.ReadOnly = true;
            this.tbTextConstitution.Size = new System.Drawing.Size(110, 26);
            this.tbTextConstitution.TabIndex = 20;
            this.tbTextConstitution.Text = "Constitution";
            this.tbTextConstitution.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbTextDexterity
            // 
            this.tbTextDexterity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextDexterity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextDexterity.Location = new System.Drawing.Point(51, 325);
            this.tbTextDexterity.Name = "tbTextDexterity";
            this.tbTextDexterity.ReadOnly = true;
            this.tbTextDexterity.Size = new System.Drawing.Size(79, 26);
            this.tbTextDexterity.TabIndex = 19;
            this.tbTextDexterity.Text = "Dexterity";
            this.tbTextDexterity.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbTextStrength
            // 
            this.tbTextStrength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextStrength.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextStrength.Location = new System.Drawing.Point(51, 293);
            this.tbTextStrength.Name = "tbTextStrength";
            this.tbTextStrength.ReadOnly = true;
            this.tbTextStrength.Size = new System.Drawing.Size(79, 26);
            this.tbTextStrength.TabIndex = 18;
            this.tbTextStrength.Text = "Strength";
            // 
            // tbChooseCharacter
            // 
            this.tbChooseCharacter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbChooseCharacter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbChooseCharacter.Location = new System.Drawing.Point(18, 91);
            this.tbChooseCharacter.Name = "tbChooseCharacter";
            this.tbChooseCharacter.ReadOnly = true;
            this.tbChooseCharacter.Size = new System.Drawing.Size(153, 26);
            this.tbChooseCharacter.TabIndex = 17;
            this.tbChooseCharacter.Text = "Choose character";
            this.tbChooseCharacter.TextChanged += new System.EventHandler(this.tbChooseCharacter_TextChanged);
            // 
            // tbTextHP
            // 
            this.tbTextHP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextHP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextHP.Location = new System.Drawing.Point(150, 59);
            this.tbTextHP.Name = "tbTextHP";
            this.tbTextHP.ReadOnly = true;
            this.tbTextHP.Size = new System.Drawing.Size(34, 26);
            this.tbTextHP.TabIndex = 19;
            this.tbTextHP.Text = "HP";
            this.tbTextHP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbTextMP
            // 
            this.tbTextMP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextMP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextMP.Location = new System.Drawing.Point(150, 122);
            this.tbTextMP.Name = "tbTextMP";
            this.tbTextMP.ReadOnly = true;
            this.tbTextMP.Size = new System.Drawing.Size(44, 26);
            this.tbTextMP.TabIndex = 20;
            this.tbTextMP.Text = "MP";
            // 
            // tbTextDamage
            // 
            this.tbTextDamage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextDamage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextDamage.Location = new System.Drawing.Point(129, 185);
            this.tbTextDamage.Name = "tbTextDamage";
            this.tbTextDamage.ReadOnly = true;
            this.tbTextDamage.Size = new System.Drawing.Size(79, 26);
            this.tbTextDamage.TabIndex = 21;
            this.tbTextDamage.Text = "Damage";
            // 
            // tbTextPhysDef
            // 
            this.tbTextPhysDef.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextPhysDef.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextPhysDef.Location = new System.Drawing.Point(89, 248);
            this.tbTextPhysDef.Name = "tbTextPhysDef";
            this.tbTextPhysDef.ReadOnly = true;
            this.tbTextPhysDef.Size = new System.Drawing.Size(146, 26);
            this.tbTextPhysDef.TabIndex = 22;
            this.tbTextPhysDef.Text = "Physical defense";
            this.tbTextPhysDef.TextChanged += new System.EventHandler(this.tbTextPhysDef_TextChanged);
            // 
            // tbTextMagDamage
            // 
            this.tbTextMagDamage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextMagDamage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextMagDamage.Location = new System.Drawing.Point(89, 311);
            this.tbTextMagDamage.Name = "tbTextMagDamage";
            this.tbTextMagDamage.ReadOnly = true;
            this.tbTextMagDamage.Size = new System.Drawing.Size(146, 26);
            this.tbTextMagDamage.TabIndex = 23;
            this.tbTextMagDamage.Text = "Magical damage";
            // 
            // pnlCharacteristics
            // 
            this.pnlCharacteristics.Controls.Add(this.tbHP);
            this.pnlCharacteristics.Controls.Add(this.tbTextMagDamage);
            this.pnlCharacteristics.Controls.Add(this.tbTextHP);
            this.pnlCharacteristics.Controls.Add(this.tbMagDamage);
            this.pnlCharacteristics.Controls.Add(this.tbTextPhysDef);
            this.pnlCharacteristics.Controls.Add(this.tbMP);
            this.pnlCharacteristics.Controls.Add(this.tbTextDamage);
            this.pnlCharacteristics.Controls.Add(this.tbPhysDef);
            this.pnlCharacteristics.Controls.Add(this.tbTextMP);
            this.pnlCharacteristics.Controls.Add(this.tbDamage);
            this.pnlCharacteristics.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCharacteristics.Location = new System.Drawing.Point(599, 0);
            this.pnlCharacteristics.Name = "pnlCharacteristics";
            this.pnlCharacteristics.Size = new System.Drawing.Size(236, 510);
            this.pnlCharacteristics.TabIndex = 24;
            // 
            // tbInventory
            // 
            this.tbInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInventory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbInventory.Location = new System.Drawing.Point(339, 100);
            this.tbInventory.Name = "tbInventory";
            this.tbInventory.ReadOnly = true;
            this.tbInventory.Size = new System.Drawing.Size(85, 26);
            this.tbInventory.TabIndex = 25;
            this.tbInventory.Text = "Inventory";
            // 
            // cmbInventory
            // 
            this.cmbInventory.FormattingEnabled = true;
            this.cmbInventory.Location = new System.Drawing.Point(430, 103);
            this.cmbInventory.Name = "cmbInventory";
            this.cmbInventory.Size = new System.Drawing.Size(156, 25);
            this.cmbInventory.TabIndex = 29;
            // 
            // tbAddItem
            // 
            this.tbAddItem.Location = new System.Drawing.Point(389, 195);
            this.tbAddItem.Name = "tbAddItem";
            this.tbAddItem.Size = new System.Drawing.Size(156, 25);
            this.tbAddItem.TabIndex = 30;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(430, 226);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 26);
            this.btnAddItem.TabIndex = 31;
            this.btnAddItem.Text = "Create";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // CharacterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 510);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.tbAddItem);
            this.Controls.Add(this.cmbInventory);
            this.Controls.Add(this.tbInventory);
            this.Controls.Add(this.pnlCharacteristics);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CharacterEditor";
            this.Text = "Character editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlCharacteristics.ResumeLayout(false);
            this.pnlCharacteristics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbCharacters;
        private TextBox tbStrength;
        private TextBox tbDexterity;
        private TextBox tbConstitution;
        private TextBox tbInteligence;
        private Button btnCreateCharacter;
        private TextBox tbHP;
        private TextBox tbMP;
        private TextBox tbDamage;
        private TextBox tbPhysDef;
        private TextBox tbMagDamage;
        private Button btnIncreaseStrength;
        private Button btnIncreaseDexterity;
        private Button btnIncreaseConstitution;
        private Button btnIncreaseInteligence;
        private TextBox tbCountOfPoints;
        private Button btnSaveCharacter;
        private Panel pnlMain;
        private TextBox tbTextDexterity;
        private TextBox tbTextStrength;
        private TextBox tbChooseCharacter;
        private TextBox tbTextConstitution;
        private TextBox tbTextInteligence;
        private TextBox tbTextHP;
        private TextBox tbTextNumberOfPoints;
        private TextBox tbTextMP;
        private TextBox tbTextDamage;
        private TextBox tbTextPhysDef;
        private TextBox tbTextMagDamage;
        private Panel pnlCharacteristics;
        private TextBox tbTextName;
        private TextBox tbName;
        private ComboBox cmbNames;
        private TextBox tbSelectFromList;
        private TextBox tbInventory;
        private ComboBox cmbInventory;
        private TextBox tbAddItem;
        private Button btnAddItem;
    }
}