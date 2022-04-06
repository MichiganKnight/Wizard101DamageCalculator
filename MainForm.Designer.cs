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
            this.LabelInfo = new System.Windows.Forms.Label();
            this.TextboxChooseSpell = new System.Windows.Forms.TextBox();
            this.PictureSpell = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSpell)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelInfo
            // 
            this.LabelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.Location = new System.Drawing.Point(532, 9);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(198, 25);
            this.LabelInfo.TabIndex = 0;
            this.LabelInfo.Text = "Enter Spell Name:";
            // 
            // TextboxChooseSpell
            // 
            this.TextboxChooseSpell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextboxChooseSpell.Location = new System.Drawing.Point(181, 37);
            this.TextboxChooseSpell.Name = "TextboxChooseSpell";
            this.TextboxChooseSpell.Size = new System.Drawing.Size(900, 32);
            this.TextboxChooseSpell.TabIndex = 1;
            this.TextboxChooseSpell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextboxChooseSpell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextboxChooseSpell_KeyDown);
            // 
            // PictureSpell
            // 
            this.PictureSpell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureSpell.Location = new System.Drawing.Point(568, 75);
            this.PictureSpell.Name = "PictureSpell";
            this.PictureSpell.Size = new System.Drawing.Size(127, 195);
            this.PictureSpell.TabIndex = 2;
            this.PictureSpell.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.ControlBox = false;
            this.Controls.Add(this.PictureSpell);
            this.Controls.Add(this.TextboxChooseSpell);
            this.Controls.Add(this.LabelInfo);
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

        private Label LabelInfo;
        private TextBox TextboxChooseSpell;
        private PictureBox PictureSpell;
    }
}