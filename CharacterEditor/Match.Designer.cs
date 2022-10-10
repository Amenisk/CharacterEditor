namespace CharacterEditor
{
    partial class Match
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
            this.SuspendLayout();
            // 
            // btnAutoGeneration
            // 
            this.btnAutoGeneration.Location = new System.Drawing.Point(30, 115);
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
            this.tbTextSecondTeam.Location = new System.Drawing.Point(459, 83);
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
            this.tbTextFirstTeam.Location = new System.Drawing.Point(168, 83);
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
            this.lbFirstTeam.Location = new System.Drawing.Point(153, 115);
            this.lbFirstTeam.Name = "lbFirstTeam";
            this.lbFirstTeam.Size = new System.Drawing.Size(120, 196);
            this.lbFirstTeam.TabIndex = 33;
            // 
            // lbSecondTeam
            // 
            this.lbSecondTeam.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSecondTeam.FormattingEnabled = true;
            this.lbSecondTeam.ItemHeight = 32;
            this.lbSecondTeam.Location = new System.Drawing.Point(455, 115);
            this.lbSecondTeam.Name = "lbSecondTeam";
            this.lbSecondTeam.Size = new System.Drawing.Size(120, 196);
            this.lbSecondTeam.TabIndex = 34;
            // 
            // btnSelect1
            // 
            this.btnSelect1.Location = new System.Drawing.Point(33, 228);
            this.btnSelect1.Name = "btnSelect1";
            this.btnSelect1.Size = new System.Drawing.Size(75, 23);
            this.btnSelect1.TabIndex = 38;
            this.btnSelect1.Text = "Select";
            this.btnSelect1.UseVisualStyleBackColor = true;
            // 
            // cmbNames1
            // 
            this.cmbNames1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNames1.FormattingEnabled = true;
            this.cmbNames1.Location = new System.Drawing.Point(1, 187);
            this.cmbNames1.Name = "cmbNames1";
            this.cmbNames1.Size = new System.Drawing.Size(146, 23);
            this.cmbNames1.TabIndex = 39;
            this.cmbNames1.SelectedIndexChanged += new System.EventHandler(this.cmbNames1_SelectedIndexChanged);
            // 
            // cmbNames2
            // 
            this.cmbNames2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNames2.FormattingEnabled = true;
            this.cmbNames2.Location = new System.Drawing.Point(289, 188);
            this.cmbNames2.Name = "cmbNames2";
            this.cmbNames2.Size = new System.Drawing.Size(146, 23);
            this.cmbNames2.TabIndex = 41;
            // 
            // btnSelect2
            // 
            this.btnSelect2.Location = new System.Drawing.Point(327, 228);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.Size = new System.Drawing.Size(75, 23);
            this.btnSelect2.TabIndex = 40;
            this.btnSelect2.Text = "Select";
            this.btnSelect2.UseVisualStyleBackColor = true;
            // 
            // Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbNames2);
            this.Controls.Add(this.btnSelect2);
            this.Controls.Add(this.cmbNames1);
            this.Controls.Add(this.btnSelect1);
            this.Controls.Add(this.btnAutoGeneration);
            this.Controls.Add(this.tbTextSecondTeam);
            this.Controls.Add(this.tbTextFirstTeam);
            this.Controls.Add(this.lbFirstTeam);
            this.Controls.Add(this.lbSecondTeam);
            this.Name = "Match";
            this.Text = "Match";
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
    }
}