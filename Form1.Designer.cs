namespace YoutubeDownloader
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.downloadButton = new System.Windows.Forms.Button();
            this.urlLabel = new System.Windows.Forms.Label();
            this.videoURLInput = new System.Windows.Forms.TextBox();
            this.downloadTypeCombo = new System.Windows.Forms.ComboBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.selectFilePathButton = new System.Windows.Forms.Button();
            this.downloadProgressBar = new CircularProgressBar.CircularProgressBar();
            this.backgroundAnimation = new System.ComponentModel.BackgroundWorker();
            this.filePathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNameInput = new System.Windows.Forms.TextBox();
            this.fileNameCheckBox = new System.Windows.Forms.CheckBox();
            this.downloadingInfoLabel = new System.Windows.Forms.Label();
            this.readyInfoLabel = new System.Windows.Forms.Label();
            this.folderPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.folderPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(163)))));
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.downloadButton.ForeColor = System.Drawing.Color.White;
            this.downloadButton.Location = new System.Drawing.Point(244, 166);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(259, 32);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButtonClick);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.urlLabel.ForeColor = System.Drawing.Color.White;
            this.urlLabel.Location = new System.Drawing.Point(12, 23);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(112, 18);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.Text = "YouTube URL";
            // 
            // videoURLInput
            // 
            this.videoURLInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(163)))));
            this.videoURLInput.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoURLInput.ForeColor = System.Drawing.Color.White;
            this.videoURLInput.Location = new System.Drawing.Point(142, 15);
            this.videoURLInput.Name = "videoURLInput";
            this.videoURLInput.Size = new System.Drawing.Size(604, 29);
            this.videoURLInput.TabIndex = 2;
            this.videoURLInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // downloadTypeCombo
            // 
            this.downloadTypeCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(163)))));
            this.downloadTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.downloadTypeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadTypeCombo.FormattingEnabled = true;
            this.downloadTypeCombo.Items.AddRange(new object[] {
            "Video Only",
            "Audio Only",
            "Video and Audio"});
            this.downloadTypeCombo.Location = new System.Drawing.Point(15, 174);
            this.downloadTypeCombo.Name = "downloadTypeCombo";
            this.downloadTypeCombo.Size = new System.Drawing.Size(200, 21);
            this.downloadTypeCombo.TabIndex = 3;
            this.downloadTypeCombo.SelectedIndexChanged += new System.EventHandler(this.onTypeComboListChange);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pathLabel.ForeColor = System.Drawing.Color.White;
            this.pathLabel.Location = new System.Drawing.Point(12, 72);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(115, 18);
            this.pathLabel.TabIndex = 5;
            this.pathLabel.Text = "Save Location";
            // 
            // selectFilePathButton
            // 
            this.selectFilePathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(163)))));
            this.selectFilePathButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectFilePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFilePathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectFilePathButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectFilePathButton.Location = new System.Drawing.Point(142, 62);
            this.selectFilePathButton.Name = "selectFilePathButton";
            this.selectFilePathButton.Size = new System.Drawing.Size(604, 32);
            this.selectFilePathButton.TabIndex = 6;
            this.selectFilePathButton.Text = "C:\\Users\\Blackhat\\Download";
            this.selectFilePathButton.UseVisualStyleBackColor = false;
            this.selectFilePathButton.Click += new System.EventHandler(this.selectFilePathButtonClick);
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.downloadProgressBar.AnimationSpeed = 1600;
            this.downloadProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.downloadProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.downloadProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.downloadProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(107)))));
            this.downloadProgressBar.InnerMargin = 2;
            this.downloadProgressBar.InnerWidth = -1;
            this.downloadProgressBar.Location = new System.Drawing.Point(528, 161);
            this.downloadProgressBar.MarqueeAnimationSpeed = 1600;
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(163)))));
            this.downloadProgressBar.OuterMargin = -25;
            this.downloadProgressBar.OuterWidth = 26;
            this.downloadProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.downloadProgressBar.ProgressWidth = 8;
            this.downloadProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.downloadProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.downloadProgressBar.Size = new System.Drawing.Size(42, 42);
            this.downloadProgressBar.StartAngle = 10;
            this.downloadProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.downloadProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.downloadProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.downloadProgressBar.SubscriptText = ".23";
            this.downloadProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.downloadProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.downloadProgressBar.SuperscriptText = "";
            this.downloadProgressBar.TabIndex = 7;
            this.downloadProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.downloadProgressBar.UseWaitCursor = true;
            this.downloadProgressBar.Value = 62;
            this.downloadProgressBar.Visible = false;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileNameLabel.ForeColor = System.Drawing.Color.White;
            this.fileNameLabel.Location = new System.Drawing.Point(12, 122);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(84, 18);
            this.fileNameLabel.TabIndex = 11;
            this.fileNameLabel.Text = "File Name";
            // 
            // fileNameInput
            // 
            this.fileNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(163)))));
            this.fileNameInput.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameInput.ForeColor = System.Drawing.Color.White;
            this.fileNameInput.Location = new System.Drawing.Point(142, 111);
            this.fileNameInput.Name = "fileNameInput";
            this.fileNameInput.Size = new System.Drawing.Size(430, 29);
            this.fileNameInput.TabIndex = 12;
            this.fileNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fileNameCheckBox
            // 
            this.fileNameCheckBox.AutoSize = true;
            this.fileNameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileNameCheckBox.ForeColor = System.Drawing.Color.White;
            this.fileNameCheckBox.Location = new System.Drawing.Point(608, 116);
            this.fileNameCheckBox.Name = "fileNameCheckBox";
            this.fileNameCheckBox.Size = new System.Drawing.Size(138, 19);
            this.fileNameCheckBox.TabIndex = 14;
            this.fileNameCheckBox.Text = "Same as on youtube";
            this.fileNameCheckBox.UseVisualStyleBackColor = true;
            this.fileNameCheckBox.CheckedChanged += new System.EventHandler(this.onFileNameCheckBoxChange);
            // 
            // downloadingInfoLabel
            // 
            this.downloadingInfoLabel.AutoSize = true;
            this.downloadingInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.downloadingInfoLabel.ForeColor = System.Drawing.Color.White;
            this.downloadingInfoLabel.Location = new System.Drawing.Point(576, 174);
            this.downloadingInfoLabel.Name = "downloadingInfoLabel";
            this.downloadingInfoLabel.Size = new System.Drawing.Size(165, 18);
            this.downloadingInfoLabel.TabIndex = 15;
            this.downloadingInfoLabel.Text = "Downloading video...";
            this.downloadingInfoLabel.Visible = false;
            // 
            // readyInfoLabel
            // 
            this.readyInfoLabel.AutoSize = true;
            this.readyInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.readyInfoLabel.ForeColor = System.Drawing.Color.White;
            this.readyInfoLabel.Location = new System.Drawing.Point(576, 173);
            this.readyInfoLabel.Name = "readyInfoLabel";
            this.readyInfoLabel.Size = new System.Drawing.Size(55, 18);
            this.readyInfoLabel.TabIndex = 16;
            this.readyInfoLabel.Text = "Ready";
            this.readyInfoLabel.Visible = false;
            // 
            // folderPicture
            // 
            this.folderPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.folderPicture.Image = global::YoutubeDownloader.Properties.Resources.folder;
            this.folderPicture.Location = new System.Drawing.Point(540, 171);
            this.folderPicture.Name = "folderPicture";
            this.folderPicture.Size = new System.Drawing.Size(21, 21);
            this.folderPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.folderPicture.TabIndex = 18;
            this.folderPicture.TabStop = false;
            this.folderPicture.Visible = false;
            this.folderPicture.Click += new System.EventHandler(this.openExplorerAtDownloadLocation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(758, 509);
            this.Controls.Add(this.folderPicture);
            this.Controls.Add(this.readyInfoLabel);
            this.Controls.Add(this.downloadingInfoLabel);
            this.Controls.Add(this.fileNameCheckBox);
            this.Controls.Add(this.fileNameInput);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.downloadProgressBar);
            this.Controls.Add(this.selectFilePathButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.downloadTypeCombo);
            this.Controls.Add(this.videoURLInput);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.downloadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.folderPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox videoURLInput;
        private System.Windows.Forms.ComboBox downloadTypeCombo;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button selectFilePathButton;
        private CircularProgressBar.CircularProgressBar downloadProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundAnimation;
        private System.Windows.Forms.FolderBrowserDialog filePathDialog;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileNameInput;
        private System.Windows.Forms.CheckBox fileNameCheckBox;
        private System.Windows.Forms.Label downloadingInfoLabel;
        private System.Windows.Forms.Label readyInfoLabel;
        private System.Windows.Forms.PictureBox folderPicture;
    }
}

