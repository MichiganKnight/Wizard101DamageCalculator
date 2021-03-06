namespace Wizard101DamageCalculator
{
    partial class MainForm
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
            this.LabelInfo2 = new System.Windows.Forms.Label();
            this.TextBoxChooseSpell = new System.Windows.Forms.TextBox();
            this.PictureSpell = new System.Windows.Forms.PictureBox();
            this.LabelInfo1 = new System.Windows.Forms.Label();
            this.LabelInfo3 = new System.Windows.Forms.Label();
            this.TextBoxBoostPlus = new System.Windows.Forms.TextBox();
            this.TextBoxBoostPercent = new System.Windows.Forms.TextBox();
            this.LabelMinimumOrSingleDamage = new System.Windows.Forms.Label();
            this.labelMaximumDamage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSpell)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelInfo2
            // 
            this.LabelInfo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelInfo2.AutoSize = true;
            this.LabelInfo2.Location = new System.Drawing.Point(532, 79);
            this.LabelInfo2.Name = "LabelInfo2";
            this.LabelInfo2.Size = new System.Drawing.Size(198, 25);
            this.LabelInfo2.TabIndex = 0;
            this.LabelInfo2.Text = "Enter Spell Name:";
            this.LabelInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxChooseSpell
            // 
            this.TextBoxChooseSpell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxChooseSpell.Location = new System.Drawing.Point(181, 107);
            this.TextBoxChooseSpell.Name = "TextBoxChooseSpell";
            this.TextBoxChooseSpell.Size = new System.Drawing.Size(900, 32);
            this.TextBoxChooseSpell.TabIndex = 3;
            this.TextBoxChooseSpell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxChooseSpell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextboxChooseSpell_KeyDown);
            // 
            // PictureSpell
            // 
            this.PictureSpell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureSpell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureSpell.Location = new System.Drawing.Point(568, 145);
            this.PictureSpell.Name = "PictureSpell";
            this.PictureSpell.Size = new System.Drawing.Size(127, 195);
            this.PictureSpell.TabIndex = 2;
            this.PictureSpell.TabStop = false;
            this.PictureSpell.Click += new System.EventHandler(this.PictureSpell_Click);
            // 
            // LabelInfo1
            // 
            this.LabelInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelInfo1.AutoSize = true;
            this.LabelInfo1.Location = new System.Drawing.Point(480, 47);
            this.LabelInfo1.Name = "LabelInfo1";
            this.LabelInfo1.Size = new System.Drawing.Size(250, 25);
            this.LabelInfo1.TabIndex = 3;
            this.LabelInfo1.Text = "Enter Player Boost (+):";
            this.LabelInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelInfo3
            // 
            this.LabelInfo3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelInfo3.AutoSize = true;
            this.LabelInfo3.Location = new System.Drawing.Point(474, 9);
            this.LabelInfo3.Name = "LabelInfo3";
            this.LabelInfo3.Size = new System.Drawing.Size(256, 25);
            this.LabelInfo3.TabIndex = 4;
            this.LabelInfo3.Text = "Enter Player Boost (%):";
            this.LabelInfo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxBoostPlus
            // 
            this.TextBoxBoostPlus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxBoostPlus.Location = new System.Drawing.Point(736, 44);
            this.TextBoxBoostPlus.Name = "TextBoxBoostPlus";
            this.TextBoxBoostPlus.Size = new System.Drawing.Size(52, 32);
            this.TextBoxBoostPlus.TabIndex = 2;
            this.TextBoxBoostPlus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxBoostPlus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxBoostPlus_KeyDown);
            // 
            // TextBoxBoostPercent
            // 
            this.TextBoxBoostPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxBoostPercent.Location = new System.Drawing.Point(736, 6);
            this.TextBoxBoostPercent.Name = "TextBoxBoostPercent";
            this.TextBoxBoostPercent.Size = new System.Drawing.Size(52, 32);
            this.TextBoxBoostPercent.TabIndex = 1;
            this.TextBoxBoostPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxBoostPercent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxBoostPercent_KeyDown);
            // 
            // LabelMinimumOrSingleDamage
            // 
            this.LabelMinimumOrSingleDamage.AutoSize = true;
            this.LabelMinimumOrSingleDamage.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelMinimumOrSingleDamage.Location = new System.Drawing.Point(474, 343);
            this.LabelMinimumOrSingleDamage.Name = "LabelMinimumOrSingleDamage";
            this.LabelMinimumOrSingleDamage.Size = new System.Drawing.Size(0, 36);
            this.LabelMinimumOrSingleDamage.TabIndex = 5;
            this.LabelMinimumOrSingleDamage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaximumDamage
            // 
            this.labelMaximumDamage.AutoSize = true;
            this.labelMaximumDamage.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMaximumDamage.Location = new System.Drawing.Point(470, 379);
            this.labelMaximumDamage.Name = "labelMaximumDamage";
            this.labelMaximumDamage.Size = new System.Drawing.Size(0, 36);
            this.labelMaximumDamage.TabIndex = 6;
            this.labelMaximumDamage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.ControlBox = false;
            this.Controls.Add(this.labelMaximumDamage);
            this.Controls.Add(this.LabelMinimumOrSingleDamage);
            this.Controls.Add(this.TextBoxBoostPercent);
            this.Controls.Add(this.TextBoxBoostPlus);
            this.Controls.Add(this.LabelInfo3);
            this.Controls.Add(this.LabelInfo1);
            this.Controls.Add(this.PictureSpell);
            this.Controls.Add(this.TextBoxChooseSpell);
            this.Controls.Add(this.LabelInfo2);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wizard101 Damage Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureSpell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelInfo2;
        private TextBox TextBoxChooseSpell;
        private PictureBox PictureSpell;
        private Label LabelInfo1;
        private Label LabelInfo3;
        private TextBox TextBoxBoostPlus;
        private TextBox TextBoxBoostPercent;
        private Label LabelMinimumOrSingleDamage;
        private Label labelMaximumDamage;
    }
}