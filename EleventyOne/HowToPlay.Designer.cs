namespace EleventyOne {
    partial class HowToPlay {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlay));
            this.lblTitle = new EleventyOne.AALabel();
            this.btnBack = new BoinBoxNS.BoinBox();
            this.lblRules = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(170, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 59);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "How To Play";
            // 
            // btnBack
            // 
            this.btnBack.AntiAliased = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBack.BorderColor = System.Drawing.Color.Empty;
            this.btnBack.BorderSize = 0;
            this.btnBack.FakeDisabled = false;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnBack.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnBack.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnBack.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 39);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblRules
            // 
            this.lblRules.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRules.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(118, 79);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(365, 181);
            this.lblRules.TabIndex = 9;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Name = "HowToPlay";
            this.Size = new System.Drawing.Size(600, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AALabel lblTitle;
        private BoinBoxNS.BoinBox btnBack;
        private System.Windows.Forms.Label lblRules;
    }
}
