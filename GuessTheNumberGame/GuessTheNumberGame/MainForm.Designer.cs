namespace GuessTheNumberGame
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbLevelRange = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblGuessTheNumber = new System.Windows.Forms.Label();
            this.lblTriesText = new System.Windows.Forms.Label();
            this.lblTries = new System.Windows.Forms.Label();
            this.lblUp = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btnCheckTheNumber = new System.Windows.Forms.Button();
            this.pbUpDown = new System.Windows.Forms.PictureBox();
            this.pbThumbsUpDown = new System.Windows.Forms.PictureBox();
            this.lblDown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose level of difficult:";
            // 
            // cbLevelRange
            // 
            this.cbLevelRange.AutoCompleteCustomSource.AddRange(new string[] {
            "1-10",
            "1-50",
            "1-100"});
            this.cbLevelRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevelRange.FormattingEnabled = true;
            this.cbLevelRange.Items.AddRange(new object[] {
            "1-10",
            "1-50",
            "1-100"});
            this.cbLevelRange.Location = new System.Drawing.Point(12, 57);
            this.cbLevelRange.Name = "cbLevelRange";
            this.cbLevelRange.Size = new System.Drawing.Size(150, 21);
            this.cbLevelRange.TabIndex = 1;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Green;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlay.Location = new System.Drawing.Point(229, 29);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(105, 54);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblGuessTheNumber
            // 
            this.lblGuessTheNumber.AutoSize = true;
            this.lblGuessTheNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGuessTheNumber.Location = new System.Drawing.Point(25, 110);
            this.lblGuessTheNumber.Name = "lblGuessTheNumber";
            this.lblGuessTheNumber.Size = new System.Drawing.Size(212, 18);
            this.lblGuessTheNumber.TabIndex = 3;
            this.lblGuessTheNumber.Text = "Guess the random number!";
            this.lblGuessTheNumber.Visible = false;
            // 
            // lblTriesText
            // 
            this.lblTriesText.AutoSize = true;
            this.lblTriesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTriesText.Location = new System.Drawing.Point(12, 208);
            this.lblTriesText.Name = "lblTriesText";
            this.lblTriesText.Size = new System.Drawing.Size(48, 16);
            this.lblTriesText.TabIndex = 4;
            this.lblTriesText.Text = "Tries:";
            this.lblTriesText.Visible = false;
            // 
            // lblTries
            // 
            this.lblTries.AutoSize = true;
            this.lblTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTries.Location = new System.Drawing.Point(66, 208);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(16, 16);
            this.lblTries.TabIndex = 5;
            this.lblTries.Text = "0";
            this.lblTries.Visible = false;
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Location = new System.Drawing.Point(277, 227);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(24, 13);
            this.lblUp.TabIndex = 6;
            this.lblUp.Text = "Up!";
            this.lblUp.Visible = false;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNote.ForeColor = System.Drawing.Color.Red;
            this.lblNote.Location = new System.Drawing.Point(9, 406);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(117, 15);
            this.lblNote.TabIndex = 7;
            this.lblNote.Text = "You have 10 tries only!";
            this.lblNote.Visible = false;
            // 
            // tbNumber
            // 
            this.tbNumber.AutoCompleteCustomSource.AddRange(new string[] {
            "1-10",
            "1-50",
            "1-100"});
            this.tbNumber.Location = new System.Drawing.Point(50, 167);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(54, 20);
            this.tbNumber.TabIndex = 8;
            this.tbNumber.Visible = false;
            // 
            // btnCheckTheNumber
            // 
            this.btnCheckTheNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckTheNumber.Location = new System.Drawing.Point(131, 154);
            this.btnCheckTheNumber.Name = "btnCheckTheNumber";
            this.btnCheckTheNumber.Size = new System.Drawing.Size(85, 44);
            this.btnCheckTheNumber.TabIndex = 9;
            this.btnCheckTheNumber.Text = "Check the number";
            this.btnCheckTheNumber.UseVisualStyleBackColor = true;
            this.btnCheckTheNumber.Visible = false;
            this.btnCheckTheNumber.Click += new System.EventHandler(this.btnCheckTheNumber_Click);
            // 
            // pbUpDown
            // 
            this.pbUpDown.Location = new System.Drawing.Point(239, 143);
            this.pbUpDown.Name = "pbUpDown";
            this.pbUpDown.Size = new System.Drawing.Size(95, 81);
            this.pbUpDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpDown.TabIndex = 10;
            this.pbUpDown.TabStop = false;
            this.pbUpDown.Visible = false;
            // 
            // pbThumbsUpDown
            // 
            this.pbThumbsUpDown.Location = new System.Drawing.Point(98, 256);
            this.pbThumbsUpDown.Name = "pbThumbsUpDown";
            this.pbThumbsUpDown.Size = new System.Drawing.Size(139, 133);
            this.pbThumbsUpDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThumbsUpDown.TabIndex = 11;
            this.pbThumbsUpDown.TabStop = false;
            this.pbThumbsUpDown.Visible = false;
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.Location = new System.Drawing.Point(277, 256);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(38, 13);
            this.lblDown.TabIndex = 12;
            this.lblDown.Text = "Down!";
            this.lblDown.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.pbThumbsUpDown);
            this.Controls.Add(this.pbUpDown);
            this.Controls.Add(this.btnCheckTheNumber);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblUp);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.lblTriesText);
            this.Controls.Add(this.lblGuessTheNumber);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.cbLevelRange);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess the number";
            ((System.ComponentModel.ISupportInitialize)(this.pbUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLevelRange;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblGuessTheNumber;
        private System.Windows.Forms.Label lblTriesText;
        private System.Windows.Forms.Label lblTries;
        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btnCheckTheNumber;
        private System.Windows.Forms.PictureBox pbUpDown;
        private System.Windows.Forms.PictureBox pbThumbsUpDown;
        private System.Windows.Forms.Label lblDown;
    }
}

