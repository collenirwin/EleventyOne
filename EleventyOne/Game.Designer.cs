namespace EleventyOne {
    partial class Game {
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
            this.components = new System.ComponentModel.Container();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.lblPlayer4 = new System.Windows.Forms.Label();
            this.lblPlayer5 = new System.Windows.Forms.Label();
            this.lblPlayerTitle = new System.Windows.Forms.Label();
            this.txtGame = new System.Windows.Forms.RichTextBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.tmrTurn = new System.Windows.Forms.Timer(this.components);
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnRoll = new BoinBoxNS.BoinBox();
            this.btnEndTurn = new BoinBoxNS.BoinBox();
            this.btnQuit = new BoinBoxNS.BoinBox();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoEllipsis = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblPlayer1.Location = new System.Drawing.Point(0, 41);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(164, 30);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "[111]Player1";
            this.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPlayer1.Visible = false;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoEllipsis = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.LightCoral;
            this.lblPlayer2.Location = new System.Drawing.Point(0, 71);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(164, 30);
            this.lblPlayer2.TabIndex = 1;
            this.lblPlayer2.Text = "[111][AI]Giuseppina";
            this.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPlayer2.Visible = false;
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.AutoEllipsis = true;
            this.lblPlayer3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPlayer3.Location = new System.Drawing.Point(0, 101);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(164, 30);
            this.lblPlayer3.TabIndex = 2;
            this.lblPlayer3.Text = "Player3";
            this.lblPlayer3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPlayer3.Visible = false;
            // 
            // lblPlayer4
            // 
            this.lblPlayer4.AutoEllipsis = true;
            this.lblPlayer4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblPlayer4.Location = new System.Drawing.Point(0, 131);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(164, 30);
            this.lblPlayer4.TabIndex = 3;
            this.lblPlayer4.Text = "Player4";
            this.lblPlayer4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPlayer4.Visible = false;
            // 
            // lblPlayer5
            // 
            this.lblPlayer5.AutoEllipsis = true;
            this.lblPlayer5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer5.ForeColor = System.Drawing.Color.Tan;
            this.lblPlayer5.Location = new System.Drawing.Point(0, 161);
            this.lblPlayer5.Name = "lblPlayer5";
            this.lblPlayer5.Size = new System.Drawing.Size(164, 30);
            this.lblPlayer5.TabIndex = 4;
            this.lblPlayer5.Text = "Player5";
            this.lblPlayer5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPlayer5.Visible = false;
            // 
            // lblPlayerTitle
            // 
            this.lblPlayerTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblPlayerTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPlayerTitle.Name = "lblPlayerTitle";
            this.lblPlayerTitle.Size = new System.Drawing.Size(164, 31);
            this.lblPlayerTitle.TabIndex = 5;
            this.lblPlayerTitle.Text = "Players";
            this.lblPlayerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGame
            // 
            this.txtGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtGame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGame.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGame.Location = new System.Drawing.Point(163, 0);
            this.txtGame.Name = "txtGame";
            this.txtGame.ReadOnly = true;
            this.txtGame.Size = new System.Drawing.Size(437, 235);
            this.txtGame.TabIndex = 6;
            this.txtGame.TabStop = false;
            this.txtGame.Text = "";
            // 
            // lblTurn
            // 
            this.lblTurn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTurn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTurn.Location = new System.Drawing.Point(96, 244);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(324, 30);
            this.lblTurn.TabIndex = 10;
            this.lblTurn.Tag = "\'s turn";
            this.lblTurn.Text = "Player1\'s turn";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrTurn
            // 
            this.tmrTurn.Interval = 500;
            this.tmrTurn.Tick += new System.EventHandler(this.tmrTurn_Tick);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Controls.Add(this.btnRoll);
            this.pnlButtons.Controls.Add(this.btnEndTurn);
            this.pnlButtons.Location = new System.Drawing.Point(424, 241);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(200, 100);
            this.pnlButtons.TabIndex = 11;
            // 
            // btnRoll
            // 
            this.btnRoll.AntiAliased = false;
            this.btnRoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRoll.BorderColor = System.Drawing.Color.Empty;
            this.btnRoll.BorderSize = 0;
            this.btnRoll.FakeDisabled = false;
            this.btnRoll.FlatAppearance.BorderSize = 0;
            this.btnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnRoll.Location = new System.Drawing.Point(1, 1);
            this.btnRoll.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnRoll.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnRoll.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnRoll.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(77, 39);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.AntiAliased = false;
            this.btnEndTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnEndTurn.BorderColor = System.Drawing.Color.Empty;
            this.btnEndTurn.BorderSize = 0;
            this.btnEndTurn.FakeDisabled = false;
            this.btnEndTurn.FlatAppearance.BorderSize = 0;
            this.btnEndTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndTurn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndTurn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnEndTurn.Location = new System.Drawing.Point(84, 1);
            this.btnEndTurn.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnEndTurn.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnEndTurn.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnEndTurn.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(77, 39);
            this.btnEndTurn.TabIndex = 1;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = false;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuit.AntiAliased = false;
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnQuit.BorderColor = System.Drawing.Color.Empty;
            this.btnQuit.BorderSize = 0;
            this.btnQuit.FakeDisabled = false;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnQuit.Location = new System.Drawing.Point(13, 241);
            this.btnQuit.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnQuit.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnQuit.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnQuit.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(77, 39);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.TabStop = false;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtGame);
            this.Controls.Add(this.lblPlayerTitle);
            this.Controls.Add(this.lblPlayer5);
            this.Controls.Add(this.lblPlayer4);
            this.Controls.Add(this.lblPlayer3);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(600, 300);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer3;
        private System.Windows.Forms.Label lblPlayer4;
        private System.Windows.Forms.Label lblPlayer5;
        private System.Windows.Forms.Label lblPlayerTitle;
        private System.Windows.Forms.RichTextBox txtGame;
        private BoinBoxNS.BoinBox btnRoll;
        private BoinBoxNS.BoinBox btnEndTurn;
        private BoinBoxNS.BoinBox btnQuit;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Timer tmrTurn;
        private System.Windows.Forms.Panel pnlButtons;
    }
}
