namespace EleventyOne {
    partial class SinglePlayerSetup {
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
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.radIdiot = new System.Windows.Forms.RadioButton();
            this.radCoward = new System.Windows.Forms.RadioButton();
            this.radCautious = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radAggressive = new System.Windows.Forms.RadioButton();
            this.radRandom = new System.Windows.Forms.RadioButton();
            this.btnBack = new BoinBoxNS.BoinBox();
            this.udOpponents = new EleventyOne.UpDown();
            this.btnPlay = new BoinBoxNS.BoinBox();
            this.lblTitle = new EleventyOne.AALabel();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPlayerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayerName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(108, 104);
            this.txtPlayerName.MaxLength = 10;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(384, 26);
            this.txtPlayerName.TabIndex = 0;
            this.txtPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(104, 82);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(91, 19);
            this.lblPlayerName.TabIndex = 7;
            this.lblPlayerName.Text = "Player Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Opponents";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(233, 207);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(134, 19);
            this.lblDifficulty.TabIndex = 11;
            this.lblDifficulty.Text = "Opponent Behavior";
            // 
            // radIdiot
            // 
            this.radIdiot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radIdiot.AutoSize = true;
            this.radIdiot.Location = new System.Drawing.Point(167, 234);
            this.radIdiot.Name = "radIdiot";
            this.radIdiot.Size = new System.Drawing.Size(45, 17);
            this.radIdiot.TabIndex = 12;
            this.radIdiot.Text = "Idiot";
            this.radIdiot.UseVisualStyleBackColor = true;
            this.radIdiot.CheckedChanged += new System.EventHandler(this.radRandom_CheckedChanged);
            // 
            // radCoward
            // 
            this.radCoward.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCoward.AutoSize = true;
            this.radCoward.Location = new System.Drawing.Point(218, 234);
            this.radCoward.Name = "radCoward";
            this.radCoward.Size = new System.Drawing.Size(61, 17);
            this.radCoward.TabIndex = 13;
            this.radCoward.Text = "Coward";
            this.radCoward.UseVisualStyleBackColor = true;
            this.radCoward.CheckedChanged += new System.EventHandler(this.radRandom_CheckedChanged);
            // 
            // radCautious
            // 
            this.radCautious.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCautious.AutoSize = true;
            this.radCautious.Location = new System.Drawing.Point(285, 234);
            this.radCautious.Name = "radCautious";
            this.radCautious.Size = new System.Drawing.Size(66, 17);
            this.radCautious.TabIndex = 14;
            this.radCautious.Text = "Cautious";
            this.radCautious.UseVisualStyleBackColor = true;
            this.radCautious.CheckedChanged += new System.EventHandler(this.radRandom_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radMedium.AutoSize = true;
            this.radMedium.Location = new System.Drawing.Point(357, 234);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(65, 17);
            this.radMedium.TabIndex = 15;
            this.radMedium.Text = "Average";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radRandom_CheckedChanged);
            // 
            // radAggressive
            // 
            this.radAggressive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radAggressive.AutoSize = true;
            this.radAggressive.Location = new System.Drawing.Point(428, 234);
            this.radAggressive.Name = "radAggressive";
            this.radAggressive.Size = new System.Drawing.Size(77, 17);
            this.radAggressive.TabIndex = 16;
            this.radAggressive.Text = "Aggressive";
            this.radAggressive.UseVisualStyleBackColor = true;
            this.radAggressive.CheckedChanged += new System.EventHandler(this.radRandom_CheckedChanged);
            // 
            // radRandom
            // 
            this.radRandom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRandom.AutoSize = true;
            this.radRandom.Checked = true;
            this.radRandom.Location = new System.Drawing.Point(96, 234);
            this.radRandom.Name = "radRandom";
            this.radRandom.Size = new System.Drawing.Size(65, 17);
            this.radRandom.TabIndex = 17;
            this.radRandom.TabStop = true;
            this.radRandom.Text = "Random";
            this.radRandom.UseVisualStyleBackColor = true;
            this.radRandom.CheckedChanged += new System.EventHandler(this.radRandom_CheckedChanged);
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
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // udOpponents
            // 
            this.udOpponents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.udOpponents.BackColor = System.Drawing.Color.White;
            this.udOpponents.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udOpponents.Location = new System.Drawing.Point(251, 166);
            this.udOpponents.Margin = new System.Windows.Forms.Padding(6);
            this.udOpponents.max = 4;
            this.udOpponents.min = 1;
            this.udOpponents.Name = "udOpponents";
            this.udOpponents.Size = new System.Drawing.Size(99, 34);
            this.udOpponents.TabIndex = 1;
            this.udOpponents.value = 1;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlay.AntiAliased = false;
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPlay.BorderColor = System.Drawing.Color.Empty;
            this.btnPlay.BorderSize = 0;
            this.btnPlay.FakeDisabled = false;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnPlay.Location = new System.Drawing.Point(263, 263);
            this.btnPlay.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnPlay.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnPlay.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnPlay.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(77, 39);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(97, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(407, 59);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Single Player Match";
            // 
            // SinglePlayerSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.radRandom);
            this.Controls.Add(this.radAggressive);
            this.Controls.Add(this.radMedium);
            this.Controls.Add(this.radCautious);
            this.Controls.Add(this.radCoward);
            this.Controls.Add(this.radIdiot);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.udOpponents);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblTitle);
            this.Name = "SinglePlayerSetup";
            this.Size = new System.Drawing.Size(600, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AALabel lblTitle;
        private System.Windows.Forms.Label lblPlayerName;
        private BoinBoxNS.BoinBox btnPlay;
        private UpDown udOpponents;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPlayerName;
        private BoinBoxNS.BoinBox btnBack;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.RadioButton radIdiot;
        private System.Windows.Forms.RadioButton radCoward;
        private System.Windows.Forms.RadioButton radCautious;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radAggressive;
        private System.Windows.Forms.RadioButton radRandom;
    }
}
