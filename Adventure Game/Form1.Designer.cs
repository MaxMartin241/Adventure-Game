namespace Adventure_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.powerLabel = new System.Windows.Forms.Label();
            this.timeRemainingLabel = new System.Windows.Forms.Label();
            this.moralityLabel = new System.Windows.Forms.Label();
            this.knowledgeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.storyLabel = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxFore = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFore)).BeginInit();
            this.SuspendLayout();
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.powerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.powerLabel.Location = new System.Drawing.Point(31, 29);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(79, 16);
            this.powerLabel.TabIndex = 0;
            this.powerLabel.Text = "Power = 100";
            // 
            // timeRemainingLabel
            // 
            this.timeRemainingLabel.AutoSize = true;
            this.timeRemainingLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeRemainingLabel.Location = new System.Drawing.Point(31, 57);
            this.timeRemainingLabel.Name = "timeRemainingLabel";
            this.timeRemainingLabel.Size = new System.Drawing.Size(126, 16);
            this.timeRemainingLabel.TabIndex = 1;
            this.timeRemainingLabel.Text = "Time Remaining = 7";
            // 
            // moralityLabel
            // 
            this.moralityLabel.AutoSize = true;
            this.moralityLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moralityLabel.Location = new System.Drawing.Point(31, 87);
            this.moralityLabel.Name = "moralityLabel";
            this.moralityLabel.Size = new System.Drawing.Size(74, 16);
            this.moralityLabel.TabIndex = 2;
            this.moralityLabel.Text = "Morality = 0";
            // 
            // knowledgeLabel
            // 
            this.knowledgeLabel.AutoSize = true;
            this.knowledgeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.knowledgeLabel.Location = new System.Drawing.Point(31, 117);
            this.knowledgeLabel.Name = "knowledgeLabel";
            this.knowledgeLabel.Size = new System.Drawing.Size(94, 16);
            this.knowledgeLabel.TabIndex = 3;
            this.knowledgeLabel.Text = "Knowledge = 0";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startButton.Location = new System.Drawing.Point(273, 310);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(158, 67);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // storyLabel
            // 
            this.storyLabel.BackColor = System.Drawing.Color.Transparent;
            this.storyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storyLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.storyLabel.Location = new System.Drawing.Point(181, 9);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(351, 140);
            this.storyLabel.TabIndex = 5;
            this.storyLabel.Text = "label";
            this.storyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.storyLabel.Visible = false;
            // 
            // option1Button
            // 
            this.option1Button.AutoSize = true;
            this.option1Button.Location = new System.Drawing.Point(310, 172);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(75, 26);
            this.option1Button.TabIndex = 6;
            this.option1Button.Text = "button1";
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Visible = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.AutoSize = true;
            this.option2Button.Location = new System.Drawing.Point(310, 228);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(75, 26);
            this.option2Button.TabIndex = 7;
            this.option2Button.Text = "button2";
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Visible = false;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.AutoSize = true;
            this.option3Button.Location = new System.Drawing.Point(310, 278);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(75, 26);
            this.option3Button.TabIndex = 8;
            this.option3Button.Text = "button3";
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Visible = false;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(607, 406);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 9;
            this.restartButton.Text = "Restert";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restertButton_Click);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(708, 458);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 10;
            this.pictureBoxBack.TabStop = false;
            // 
            // pictureBoxFore
            // 
            this.pictureBoxFore.Location = new System.Drawing.Point(558, 228);
            this.pictureBoxFore.Name = "pictureBoxFore";
            this.pictureBoxFore.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxFore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFore.TabIndex = 11;
            this.pictureBoxFore.TabStop = false;
            this.pictureBoxFore.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.pictureBoxFore);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.storyLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.knowledgeLabel);
            this.Controls.Add(this.moralityLabel);
            this.Controls.Add(this.timeRemainingLabel);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.pictureBoxBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Adventure Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Label timeRemainingLabel;
        private System.Windows.Forms.Label moralityLabel;
        private System.Windows.Forms.Label knowledgeLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label storyLabel;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxFore;
    }
}

