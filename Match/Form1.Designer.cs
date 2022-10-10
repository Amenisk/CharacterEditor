namespace Match
{
    partial class Form1
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
            this.lbSecondTeam = new System.Windows.Forms.ListBox();
            this.tbTextFirstTeam = new System.Windows.Forms.TextBox();
            this.lbFirstTeam = new System.Windows.Forms.ListBox();
            this.tbTextSecondTeam = new System.Windows.Forms.TextBox();
            this.btnAutoGeneration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSecondTeam
            // 
            this.lbSecondTeam.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSecondTeam.FormattingEnabled = true;
            this.lbSecondTeam.ItemHeight = 32;
            this.lbSecondTeam.Location = new System.Drawing.Point(361, 107);
            this.lbSecondTeam.Name = "lbSecondTeam";
            this.lbSecondTeam.Size = new System.Drawing.Size(120, 196);
            this.lbSecondTeam.TabIndex = 1;
            // 
            // tbTextFirstTeam
            // 
            this.tbTextFirstTeam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextFirstTeam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextFirstTeam.Location = new System.Drawing.Point(168, 75);
            this.tbTextFirstTeam.Name = "tbTextFirstTeam";
            this.tbTextFirstTeam.ReadOnly = true;
            this.tbTextFirstTeam.Size = new System.Drawing.Size(89, 26);
            this.tbTextFirstTeam.TabIndex = 30;
            this.tbTextFirstTeam.Text = "First team";
            // 
            // lbFirstTeam
            // 
            this.lbFirstTeam.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFirstTeam.FormattingEnabled = true;
            this.lbFirstTeam.ItemHeight = 32;
            this.lbFirstTeam.Location = new System.Drawing.Point(153, 107);
            this.lbFirstTeam.Name = "lbFirstTeam";
            this.lbFirstTeam.Size = new System.Drawing.Size(120, 196);
            this.lbFirstTeam.TabIndex = 0;
            // 
            // tbTextSecondTeam
            // 
            this.tbTextSecondTeam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTextSecondTeam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTextSecondTeam.Location = new System.Drawing.Point(365, 75);
            this.tbTextSecondTeam.Name = "tbTextSecondTeam";
            this.tbTextSecondTeam.ReadOnly = true;
            this.tbTextSecondTeam.Size = new System.Drawing.Size(116, 26);
            this.tbTextSecondTeam.TabIndex = 31;
            this.tbTextSecondTeam.Text = "Second team";
            // 
            // btnAutoGeneration
            // 
            this.btnAutoGeneration.Location = new System.Drawing.Point(30, 107);
            this.btnAutoGeneration.Name = "btnAutoGeneration";
            this.btnAutoGeneration.Size = new System.Drawing.Size(78, 39);
            this.btnAutoGeneration.TabIndex = 32;
            this.btnAutoGeneration.Text = "Auto generation";
            this.btnAutoGeneration.UseVisualStyleBackColor = true;
            this.btnAutoGeneration.Click += new System.EventHandler(this.btnAutoGeneration_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAutoGeneration);
            this.Controls.Add(this.tbTextSecondTeam);
            this.Controls.Add(this.tbTextFirstTeam);
            this.Controls.Add(this.lbFirstTeam);
            this.Controls.Add(this.lbSecondTeam);
            this.Name = "Form1";
            this.Text = "Match";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox lbSecondTeam;
        private TextBox tbTextFirstTeam;
        private ListBox lbFirstTeam;
        private TextBox tbTextSecondTeam;
        private Button btnAutoGeneration;
    }
}