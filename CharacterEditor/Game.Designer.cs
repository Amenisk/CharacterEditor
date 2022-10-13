namespace CharacterEditor
{
    partial class Game
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
            this.btnAutoGeneration = new System.Windows.Forms.Button();
            this.tbTextSecondTeam = new System.Windows.Forms.TextBox();
            this.tbTextFirstTeam = new System.Windows.Forms.TextBox();
            this.lbFirstTeam = new System.Windows.Forms.ListBox();
            this.lbSecondTeam = new System.Windows.Forms.ListBox();
            this.btnSelect1 = new System.Windows.Forms.Button();
            this.cmbNames1 = new System.Windows.Forms.ComboBox();
            this.cmbNames2 = new System.Windows.Forms.ComboBox();
            this.btnSelect2 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.tbIsBalansed = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.cmbMatches = new System.Windows.Forms.ComboBox();
            this.btnLoadMatch = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCharacter1 = new System.Windows.Forms.Button();
            this.btnCharacter2 = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAutoGeneration
            // 
            this.btnAutoGeneration.Location = new System.Drawing.Point(38, 115);
            this.btnAutoGeneration.Name = "btnAutoGeneration";
            this.btnAutoGeneration.Size = new System.Drawing.Size(78, 39);
            this.btnAutoGeneration.TabIndex = 37;
            this.btnAutoGeneration.Text = "Auto generation";
            this.btnAutoGeneration.UseVisualStyleBackColor = true;
            this.btnAutoGeneration.Click += new System.EventHandler(this.btnAutoGeneration_Click);
            // 
            // tbTextSecondTeam
            // 
            this.tbTextSecondTeam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextSecondTeam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextSecondTeam.Location = new System.Drawing.Point(467, 83);
            this.tbTextSecondTeam.Name = "tbTextSecondTeam";
            this.tbTextSecondTeam.ReadOnly = true;
            this.tbTextSecondTeam.Size = new System.Drawing.Size(116, 26);
            this.tbTextSecondTeam.TabIndex = 36;
            this.tbTextSecondTeam.Text = "Second team";
            // 
            // tbTextFirstTeam
            // 
            this.tbTextFirstTeam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextFirstTeam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextFirstTeam.Location = new System.Drawing.Point(176, 83);
            this.tbTextFirstTeam.Name = "tbTextFirstTeam";
            this.tbTextFirstTeam.ReadOnly = true;
            this.tbTextFirstTeam.Size = new System.Drawing.Size(89, 26);
            this.tbTextFirstTeam.TabIndex = 35;
            this.tbTextFirstTeam.Text = "First team";
            // 
            // lbFirstTeam
            // 
            this.lbFirstTeam.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFirstTeam.FormattingEnabled = true;
            this.lbFirstTeam.ItemHeight = 32;
            this.lbFirstTeam.Location = new System.Drawing.Point(161, 115);
            this.lbFirstTeam.Name = "lbFirstTeam";
            this.lbFirstTeam.Size = new System.Drawing.Size(120, 196);
            this.lbFirstTeam.TabIndex = 33;
            // 
            // lbSecondTeam
            // 
            this.lbSecondTeam.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSecondTeam.FormattingEnabled = true;
            this.lbSecondTeam.ItemHeight = 32;
            this.lbSecondTeam.Location = new System.Drawing.Point(463, 115);
            this.lbSecondTeam.Name = "lbSecondTeam";
            this.lbSecondTeam.Size = new System.Drawing.Size(120, 196);
            this.lbSecondTeam.TabIndex = 34;
            // 
            // btnSelect1
            // 
            this.btnSelect1.Location = new System.Drawing.Point(41, 237);
            this.btnSelect1.Name = "btnSelect1";
            this.btnSelect1.Size = new System.Drawing.Size(75, 23);
            this.btnSelect1.TabIndex = 38;
            this.btnSelect1.Text = "Select";
            this.btnSelect1.UseVisualStyleBackColor = true;
            this.btnSelect1.Click += new System.EventHandler(this.btnSelect1_Click);
            // 
            // cmbNames1
            // 
            this.cmbNames1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNames1.FormattingEnabled = true;
            this.cmbNames1.Location = new System.Drawing.Point(9, 187);
            this.cmbNames1.Name = "cmbNames1";
            this.cmbNames1.Size = new System.Drawing.Size(146, 23);
            this.cmbNames1.TabIndex = 39;
            this.cmbNames1.SelectedIndexChanged += new System.EventHandler(this.cmbNames1_SelectedIndexChanged);
            // 
            // cmbNames2
            // 
            this.cmbNames2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNames2.FormattingEnabled = true;
            this.cmbNames2.Location = new System.Drawing.Point(297, 188);
            this.cmbNames2.Name = "cmbNames2";
            this.cmbNames2.Size = new System.Drawing.Size(146, 23);
            this.cmbNames2.TabIndex = 41;
            // 
            // btnSelect2
            // 
            this.btnSelect2.Location = new System.Drawing.Point(335, 237);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.Size = new System.Drawing.Size(75, 23);
            this.btnSelect2.TabIndex = 40;
            this.btnSelect2.Text = "Select";
            this.btnSelect2.UseVisualStyleBackColor = true;
            this.btnSelect2.Click += new System.EventHandler(this.btnSelect2_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.Location = new System.Drawing.Point(41, 275);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(75, 23);
            this.btnDelete1.TabIndex = 42;
            this.btnDelete1.Text = "Delete";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.Location = new System.Drawing.Point(335, 275);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(75, 23);
            this.btnDelete2.TabIndex = 43;
            this.btnDelete2.Text = "Delete";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btn_Click);
            // 
            // tbIsBalansed
            // 
            this.tbIsBalansed.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbIsBalansed.Location = new System.Drawing.Point(256, 405);
            this.tbIsBalansed.Name = "tbIsBalansed";
            this.tbIsBalansed.ReadOnly = true;
            this.tbIsBalansed.Size = new System.Drawing.Size(239, 33);
            this.tbIsBalansed.TabIndex = 44;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartGame.Location = new System.Drawing.Point(287, 321);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(171, 39);
            this.btnStartGame.TabIndex = 45;
            this.btnStartGame.Text = "Start game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // cmbMatches
            // 
            this.cmbMatches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMatches.FormattingEnabled = true;
            this.cmbMatches.Location = new System.Drawing.Point(620, 124);
            this.cmbMatches.Name = "cmbMatches";
            this.cmbMatches.Size = new System.Drawing.Size(155, 23);
            this.cmbMatches.TabIndex = 46;
            // 
            // btnLoadMatch
            // 
            this.btnLoadMatch.Location = new System.Drawing.Point(656, 167);
            this.btnLoadMatch.Name = "btnLoadMatch";
            this.btnLoadMatch.Size = new System.Drawing.Size(91, 23);
            this.btnLoadMatch.TabIndex = 47;
            this.btnLoadMatch.Text = "Load match";
            this.btnLoadMatch.UseVisualStyleBackColor = true;
            this.btnLoadMatch.Click += new System.EventHandler(this.btnLoadMatch_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(656, 196);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 23);
            this.btnReturn.TabIndex = 48;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCharacter1
            // 
            this.btnCharacter1.Location = new System.Drawing.Point(161, 321);
            this.btnCharacter1.Name = "btnCharacter1";
            this.btnCharacter1.Size = new System.Drawing.Size(120, 23);
            this.btnCharacter1.TabIndex = 49;
            this.btnCharacter1.Text = "Get characteristics";
            this.btnCharacter1.UseVisualStyleBackColor = true;
            this.btnCharacter1.Visible = false;
            this.btnCharacter1.Click += new System.EventHandler(this.btnCharacter1_Click);
            // 
            // btnCharacter2
            // 
            this.btnCharacter2.Location = new System.Drawing.Point(463, 321);
            this.btnCharacter2.Name = "btnCharacter2";
            this.btnCharacter2.Size = new System.Drawing.Size(120, 23);
            this.btnCharacter2.TabIndex = 50;
            this.btnCharacter2.Text = "Get characteristics";
            this.btnCharacter2.UseVisualStyleBackColor = true;
            this.btnCharacter2.Visible = false;
            this.btnCharacter2.Click += new System.EventHandler(this.btnCharacter2_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(661, 383);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 44);
            this.btnRemove.TabIndex = 51;
            this.btnRemove.Text = "Close";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCharacter2);
            this.Controls.Add(this.btnCharacter1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLoadMatch);
            this.Controls.Add(this.cmbMatches);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.tbIsBalansed);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.cmbNames2);
            this.Controls.Add(this.btnSelect2);
            this.Controls.Add(this.cmbNames1);
            this.Controls.Add(this.btnSelect1);
            this.Controls.Add(this.btnAutoGeneration);
            this.Controls.Add(this.tbTextSecondTeam);
            this.Controls.Add(this.tbTextFirstTeam);
            this.Controls.Add(this.lbFirstTeam);
            this.Controls.Add(this.lbSecondTeam);
            this.Name = "Game";
            this.Text = "Match";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Match_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAutoGeneration;
        private TextBox tbTextSecondTeam;
        private TextBox tbTextFirstTeam;
        private ListBox lbFirstTeam;
        private ListBox lbSecondTeam;
        private Button btnSelect1;
        private ComboBox cmbNames1;
        private ComboBox cmbNames2;
        private Button btnSelect2;
        private Button btnDelete1;
        private Button btnDelete2;
        private TextBox tbIsBalansed;
        private Button btnStartGame;
        private ComboBox cmbMatches;
        private Button btnLoadMatch;
        private Button btnReturn;
        private Button btnCharacter1;
        private Button btnCharacter2;
        private Button btnRemove;
    }
}