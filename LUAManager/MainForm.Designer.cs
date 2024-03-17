
using System;

namespace LUAManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            EncryptButton = new System.Windows.Forms.Button();
            DecryptButton = new System.Windows.Forms.Button();
            DecodeButton = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            encryptInputLabel = new System.Windows.Forms.Label();
            encryptOutputLabel = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            encryptInputFile = new System.Windows.Forms.Label();
            encryptPanel = new System.Windows.Forms.Panel();
            customKeyEnc = new System.Windows.Forms.TextBox();
            encryptBrotipLabel = new System.Windows.Forms.Label();
            encryptGameSelect = new System.Windows.Forms.ComboBox();
            encryptOutputFile = new System.Windows.Forms.Label();
            SevenZipCheck = new System.Windows.Forms.RadioButton();
            LZMACheck = new System.Windows.Forms.RadioButton();
            RawFileCheck = new System.Windows.Forms.RadioButton();
            decryptPanel = new System.Windows.Forms.Panel();
            autoUnlzma = new System.Windows.Forms.CheckBox();
            customKeyDec = new System.Windows.Forms.TextBox();
            decryptInputFileButton = new System.Windows.Forms.Button();
            decryptBrotipLabel = new System.Windows.Forms.Label();
            autoUnzip = new System.Windows.Forms.CheckBox();
            decryptGameSelect = new System.Windows.Forms.ComboBox();
            decryptOutputFile = new System.Windows.Forms.Label();
            decryptInputLabel = new System.Windows.Forms.Label();
            decryptInputFile = new System.Windows.Forms.Label();
            decryptOutputLabel = new System.Windows.Forms.Label();
            decryptOutputFileButton = new System.Windows.Forms.Button();
            LetsGo = new System.Windows.Forms.Button();
            decodePanel = new System.Windows.Forms.Panel();
            button3 = new System.Windows.Forms.Button();
            decodeBrotipLabel = new System.Windows.Forms.Label();
            decodeOutputFile = new System.Windows.Forms.Label();
            decodeInputLabel = new System.Windows.Forms.Label();
            decodeInputFile = new System.Windows.Forms.Label();
            decodeOutputLabel = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            folderRadio = new System.Windows.Forms.RadioButton();
            fileRadio = new System.Windows.Forms.RadioButton();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            encryptPanel.SuspendLayout();
            decryptPanel.SuspendLayout();
            decodePanel.SuspendLayout();
            SuspendLayout();
            // 
            // EncryptButton
            // 
            EncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            EncryptButton.ForeColor = System.Drawing.Color.White;
            EncryptButton.Location = new System.Drawing.Point(233, 12);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new System.Drawing.Size(59, 37);
            EncryptButton.TabIndex = 0;
            EncryptButton.Text = "Encrypt";
            EncryptButton.UseVisualStyleBackColor = true;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // DecryptButton
            // 
            DecryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            DecryptButton.ForeColor = System.Drawing.Color.White;
            DecryptButton.Location = new System.Drawing.Point(295, 12);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new System.Drawing.Size(59, 37);
            DecryptButton.TabIndex = 1;
            DecryptButton.Text = "Decrypt";
            DecryptButton.UseVisualStyleBackColor = true;
            DecryptButton.Click += DecryptButton_Click;
            // 
            // DecodeButton
            // 
            DecodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            DecodeButton.ForeColor = System.Drawing.Color.White;
            DecodeButton.Location = new System.Drawing.Point(360, 12);
            DecodeButton.Name = "DecodeButton";
            DecodeButton.Size = new System.Drawing.Size(56, 37);
            DecodeButton.TabIndex = 2;
            DecodeButton.Text = "Decode";
            DecodeButton.UseVisualStyleBackColor = true;
            DecodeButton.Click += DecodeButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(349, 378);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 78);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // encryptInputLabel
            // 
            encryptInputLabel.AutoSize = true;
            encryptInputLabel.ForeColor = System.Drawing.Color.Transparent;
            encryptInputLabel.Location = new System.Drawing.Point(3, 99);
            encryptInputLabel.Name = "encryptInputLabel";
            encryptInputLabel.Size = new System.Drawing.Size(103, 15);
            encryptInputLabel.TabIndex = 5;
            encryptInputLabel.Text = "Encrypt files from:";
            // 
            // encryptOutputLabel
            // 
            encryptOutputLabel.AutoSize = true;
            encryptOutputLabel.ForeColor = System.Drawing.Color.Transparent;
            encryptOutputLabel.Location = new System.Drawing.Point(3, 145);
            encryptOutputLabel.Name = "encryptOutputLabel";
            encryptOutputLabel.Size = new System.Drawing.Size(62, 15);
            encryptOutputLabel.TabIndex = 6;
            encryptOutputLabel.Text = "Output to:";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Green;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(99, 143);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Green;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button2.ForeColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(99, 99);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // encryptInputFile
            // 
            encryptInputFile.ForeColor = System.Drawing.Color.White;
            encryptInputFile.Location = new System.Drawing.Point(5, 122);
            encryptInputFile.Name = "encryptInputFile";
            encryptInputFile.Size = new System.Drawing.Size(398, 18);
            encryptInputFile.TabIndex = 9;
            encryptInputFile.Text = "InputFilePath";
            encryptInputFile.Visible = false;
            // 
            // encryptPanel
            // 
            encryptPanel.Controls.Add(customKeyEnc);
            encryptPanel.Controls.Add(button2);
            encryptPanel.Controls.Add(encryptBrotipLabel);
            encryptPanel.Controls.Add(encryptGameSelect);
            encryptPanel.Controls.Add(encryptOutputFile);
            encryptPanel.Controls.Add(encryptInputLabel);
            encryptPanel.Controls.Add(encryptInputFile);
            encryptPanel.Controls.Add(encryptOutputLabel);
            encryptPanel.Controls.Add(button1);
            encryptPanel.Controls.Add(SevenZipCheck);
            encryptPanel.Controls.Add(LZMACheck);
            encryptPanel.Controls.Add(RawFileCheck);
            encryptPanel.Location = new System.Drawing.Point(11, 62);
            encryptPanel.Name = "encryptPanel";
            encryptPanel.Size = new System.Drawing.Size(405, 254);
            encryptPanel.TabIndex = 10;
            // 
            // customKeyEnc
            // 
            customKeyEnc.Location = new System.Drawing.Point(155, 67);
            customKeyEnc.Name = "customKeyEnc";
            customKeyEnc.PlaceholderText = "Put a custom key here";
            customKeyEnc.Size = new System.Drawing.Size(199, 23);
            customKeyEnc.TabIndex = 29;
            customKeyEnc.Visible = false;
            // 
            // encryptBrotipLabel
            // 
            encryptBrotipLabel.AutoSize = true;
            encryptBrotipLabel.ForeColor = System.Drawing.Color.White;
            encryptBrotipLabel.Location = new System.Drawing.Point(5, 217);
            encryptBrotipLabel.Name = "encryptBrotipLabel";
            encryptBrotipLabel.Size = new System.Drawing.Size(404, 30);
            encryptBrotipLabel.TabIndex = 13;
            encryptBrotipLabel.Text = "Brotip: Newer versions of AB games always store LUAs in either 7z or LZMA \r\ncompression.";
            // 
            // encryptGameSelect
            // 
            encryptGameSelect.DisplayMember = "1";
            encryptGameSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            encryptGameSelect.FormattingEnabled = true;
            encryptGameSelect.Items.AddRange(new object[] { "Angry Birds Classic/Rio", "Angry Birds Seasons", "Angry Birds Space", "Angry Birds Star Wars", "Angry Birds Star Wars II", "Angry Birds Friends", "Custom key" });
            encryptGameSelect.Location = new System.Drawing.Point(2, 68);
            encryptGameSelect.Name = "encryptGameSelect";
            encryptGameSelect.Size = new System.Drawing.Size(146, 23);
            encryptGameSelect.TabIndex = 11;
            encryptGameSelect.SelectedIndexChanged += IndexChangeEnc;
            // 
            // encryptOutputFile
            // 
            encryptOutputFile.ForeColor = System.Drawing.Color.White;
            encryptOutputFile.Location = new System.Drawing.Point(5, 169);
            encryptOutputFile.Name = "encryptOutputFile";
            encryptOutputFile.Size = new System.Drawing.Size(398, 44);
            encryptOutputFile.TabIndex = 10;
            encryptOutputFile.Text = "OutputFilePath";
            encryptOutputFile.Visible = false;
            // 
            // SevenZipCheck
            // 
            SevenZipCheck.AutoSize = true;
            SevenZipCheck.ForeColor = System.Drawing.Color.White;
            SevenZipCheck.Location = new System.Drawing.Point(4, 24);
            SevenZipCheck.Name = "SevenZipCheck";
            SevenZipCheck.Size = new System.Drawing.Size(125, 19);
            SevenZipCheck.TabIndex = 26;
            SevenZipCheck.Text = "Export in 7z format";
            SevenZipCheck.UseVisualStyleBackColor = true;
            SevenZipCheck.CheckedChanged += SevenZipCheck_CheckedChanged;
            // 
            // LZMACheck
            // 
            LZMACheck.AutoSize = true;
            LZMACheck.ForeColor = System.Drawing.Color.White;
            LZMACheck.Location = new System.Drawing.Point(4, 41);
            LZMACheck.Name = "LZMACheck";
            LZMACheck.Size = new System.Drawing.Size(146, 19);
            LZMACheck.TabIndex = 27;
            LZMACheck.Text = "Export in LZMA format";
            LZMACheck.UseVisualStyleBackColor = true;
            // 
            // RawFileCheck
            // 
            RawFileCheck.AutoSize = true;
            RawFileCheck.Checked = true;
            RawFileCheck.ForeColor = System.Drawing.Color.White;
            RawFileCheck.Location = new System.Drawing.Point(4, 8);
            RawFileCheck.Name = "RawFileCheck";
            RawFileCheck.Size = new System.Drawing.Size(81, 19);
            RawFileCheck.TabIndex = 28;
            RawFileCheck.TabStop = true;
            RawFileCheck.Text = "Export raw";
            RawFileCheck.UseVisualStyleBackColor = true;
            // 
            // decryptPanel
            // 
            decryptPanel.Controls.Add(autoUnlzma);
            decryptPanel.Controls.Add(customKeyDec);
            decryptPanel.Controls.Add(decryptInputFileButton);
            decryptPanel.Controls.Add(decryptBrotipLabel);
            decryptPanel.Controls.Add(autoUnzip);
            decryptPanel.Controls.Add(decryptGameSelect);
            decryptPanel.Controls.Add(decryptOutputFile);
            decryptPanel.Controls.Add(decryptInputLabel);
            decryptPanel.Controls.Add(decryptInputFile);
            decryptPanel.Controls.Add(decryptOutputLabel);
            decryptPanel.Controls.Add(decryptOutputFileButton);
            decryptPanel.Location = new System.Drawing.Point(11, 61);
            decryptPanel.Name = "decryptPanel";
            decryptPanel.Size = new System.Drawing.Size(404, 275);
            decryptPanel.TabIndex = 15;
            decryptPanel.Visible = false;
            // 
            // autoUnlzma
            // 
            autoUnlzma.AutoSize = true;
            autoUnlzma.BackColor = System.Drawing.Color.Transparent;
            autoUnlzma.Checked = true;
            autoUnlzma.CheckState = System.Windows.Forms.CheckState.Checked;
            autoUnlzma.ForeColor = System.Drawing.Color.White;
            autoUnlzma.Location = new System.Drawing.Point(0, 3);
            autoUnlzma.Name = "autoUnlzma";
            autoUnlzma.Size = new System.Drawing.Size(170, 19);
            autoUnlzma.TabIndex = 21;
            autoUnlzma.Text = "Auto-decode LZMA format";
            autoUnlzma.UseVisualStyleBackColor = false;
            autoUnlzma.CheckedChanged += autoUnlzma_CheckedChanged;
            // 
            // customKeyDec
            // 
            customKeyDec.Location = new System.Drawing.Point(153, 44);
            customKeyDec.Name = "customKeyDec";
            customKeyDec.PlaceholderText = "Put a custom key here";
            customKeyDec.Size = new System.Drawing.Size(199, 23);
            customKeyDec.TabIndex = 20;
            customKeyDec.Visible = false;
            customKeyDec.TextChanged += customKeyDec_TextChanged;
            // 
            // decryptInputFileButton
            // 
            decryptInputFileButton.BackColor = System.Drawing.Color.Green;
            decryptInputFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            decryptInputFileButton.ForeColor = System.Drawing.Color.White;
            decryptInputFileButton.Location = new System.Drawing.Point(97, 70);
            decryptInputFileButton.Name = "decryptInputFileButton";
            decryptInputFileButton.Size = new System.Drawing.Size(75, 23);
            decryptInputFileButton.TabIndex = 8;
            decryptInputFileButton.Text = "Browse";
            decryptInputFileButton.UseVisualStyleBackColor = false;
            decryptInputFileButton.Click += button3_Click;
            // 
            // decryptBrotipLabel
            // 
            decryptBrotipLabel.ForeColor = System.Drawing.Color.White;
            decryptBrotipLabel.Location = new System.Drawing.Point(2, 187);
            decryptBrotipLabel.Name = "decryptBrotipLabel";
            decryptBrotipLabel.Size = new System.Drawing.Size(401, 57);
            decryptBrotipLabel.TabIndex = 13;
            decryptBrotipLabel.Text = "Brotip: Have 2 folders, one with the files to be decrypted, and another to send the files to.";
            // 
            // autoUnzip
            // 
            autoUnzip.AutoSize = true;
            autoUnzip.BackColor = System.Drawing.Color.Transparent;
            autoUnzip.Checked = true;
            autoUnzip.CheckState = System.Windows.Forms.CheckState.Checked;
            autoUnzip.ForeColor = System.Drawing.Color.White;
            autoUnzip.Location = new System.Drawing.Point(0, 25);
            autoUnzip.Name = "autoUnzip";
            autoUnzip.Size = new System.Drawing.Size(203, 19);
            autoUnzip.TabIndex = 12;
            autoUnzip.Text = "Automatically unzip 7z if required";
            autoUnzip.UseVisualStyleBackColor = false;
            autoUnzip.CheckedChanged += autoUnzip_CheckedChanged;
            // 
            // decryptGameSelect
            // 
            decryptGameSelect.DisplayMember = "1";
            decryptGameSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            decryptGameSelect.FormattingEnabled = true;
            decryptGameSelect.Items.AddRange(new object[] { "Angry Birds Classic/Rio", "Angry Birds Seasons", "Angry Birds Space", "Angry Birds Star Wars", "Angry Birds Star Wars II", "Angry Birds Friends", "Custom key" });
            decryptGameSelect.Location = new System.Drawing.Point(0, 44);
            decryptGameSelect.Name = "decryptGameSelect";
            decryptGameSelect.Size = new System.Drawing.Size(146, 23);
            decryptGameSelect.TabIndex = 11;
            decryptGameSelect.SelectedIndexChanged += checkForFifthopt;
            // 
            // decryptOutputFile
            // 
            decryptOutputFile.ForeColor = System.Drawing.Color.White;
            decryptOutputFile.Location = new System.Drawing.Point(5, 143);
            decryptOutputFile.Name = "decryptOutputFile";
            decryptOutputFile.Size = new System.Drawing.Size(398, 44);
            decryptOutputFile.TabIndex = 10;
            decryptOutputFile.Text = "OutputFilePath";
            decryptOutputFile.Visible = false;
            // 
            // decryptInputLabel
            // 
            decryptInputLabel.AutoSize = true;
            decryptInputLabel.ForeColor = System.Drawing.Color.Transparent;
            decryptInputLabel.Location = new System.Drawing.Point(3, 73);
            decryptInputLabel.Name = "decryptInputLabel";
            decryptInputLabel.Size = new System.Drawing.Size(104, 15);
            decryptInputLabel.TabIndex = 5;
            decryptInputLabel.Text = "Decrypt files from:";
            // 
            // decryptInputFile
            // 
            decryptInputFile.ForeColor = System.Drawing.Color.White;
            decryptInputFile.Location = new System.Drawing.Point(5, 96);
            decryptInputFile.Name = "decryptInputFile";
            decryptInputFile.Size = new System.Drawing.Size(398, 18);
            decryptInputFile.TabIndex = 9;
            decryptInputFile.Text = "InputFilePath";
            decryptInputFile.Visible = false;
            // 
            // decryptOutputLabel
            // 
            decryptOutputLabel.AutoSize = true;
            decryptOutputLabel.ForeColor = System.Drawing.Color.Transparent;
            decryptOutputLabel.Location = new System.Drawing.Point(3, 119);
            decryptOutputLabel.Name = "decryptOutputLabel";
            decryptOutputLabel.Size = new System.Drawing.Size(62, 15);
            decryptOutputLabel.TabIndex = 6;
            decryptOutputLabel.Text = "Output to:";
            // 
            // decryptOutputFileButton
            // 
            decryptOutputFileButton.BackColor = System.Drawing.Color.Green;
            decryptOutputFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            decryptOutputFileButton.ForeColor = System.Drawing.Color.White;
            decryptOutputFileButton.Location = new System.Drawing.Point(97, 117);
            decryptOutputFileButton.Name = "decryptOutputFileButton";
            decryptOutputFileButton.Size = new System.Drawing.Size(75, 23);
            decryptOutputFileButton.TabIndex = 7;
            decryptOutputFileButton.Text = "Browse";
            decryptOutputFileButton.UseVisualStyleBackColor = false;
            decryptOutputFileButton.Click += decryptOutputFileButton_Click;
            // 
            // LetsGo
            // 
            LetsGo.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            LetsGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            LetsGo.ForeColor = System.Drawing.Color.White;
            LetsGo.Location = new System.Drawing.Point(360, 351);
            LetsGo.Name = "LetsGo";
            LetsGo.Size = new System.Drawing.Size(56, 23);
            LetsGo.TabIndex = 11;
            LetsGo.Text = "Build";
            LetsGo.UseVisualStyleBackColor = false;
            LetsGo.Click += LetsGo_Click;
            // 
            // decodePanel
            // 
            decodePanel.Controls.Add(button3);
            decodePanel.Controls.Add(decryptPanel);
            decodePanel.Controls.Add(decodeBrotipLabel);
            decodePanel.Controls.Add(decodeOutputFile);
            decodePanel.Controls.Add(decodeInputLabel);
            decodePanel.Controls.Add(decodeInputFile);
            decodePanel.Controls.Add(decodeOutputLabel);
            decodePanel.Controls.Add(button4);
            decodePanel.Location = new System.Drawing.Point(11, 61);
            decodePanel.Name = "decodePanel";
            decodePanel.Size = new System.Drawing.Size(417, 284);
            decodePanel.TabIndex = 17;
            decodePanel.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.Green;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button3.ForeColor = System.Drawing.Color.White;
            button3.Location = new System.Drawing.Point(85, 3);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Browse";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // decodeBrotipLabel
            // 
            decodeBrotipLabel.ForeColor = System.Drawing.Color.White;
            decodeBrotipLabel.Location = new System.Drawing.Point(0, 132);
            decodeBrotipLabel.Name = "decodeBrotipLabel";
            decodeBrotipLabel.Size = new System.Drawing.Size(401, 40);
            decodeBrotipLabel.TabIndex = 13;
            decodeBrotipLabel.Text = "Brotip: Make sure all LUA files in the folder are not encrypted before you continue\r\n";
            // 
            // decodeOutputFile
            // 
            decodeOutputFile.ForeColor = System.Drawing.Color.White;
            decodeOutputFile.Location = new System.Drawing.Point(3, 76);
            decodeOutputFile.Name = "decodeOutputFile";
            decodeOutputFile.Size = new System.Drawing.Size(398, 44);
            decodeOutputFile.TabIndex = 10;
            decodeOutputFile.Text = "OutputFilePath";
            decodeOutputFile.Visible = false;
            // 
            // decodeInputLabel
            // 
            decodeInputLabel.AutoSize = true;
            decodeInputLabel.ForeColor = System.Drawing.Color.Transparent;
            decodeInputLabel.Location = new System.Drawing.Point(1, 6);
            decodeInputLabel.Name = "decodeInputLabel";
            decodeInputLabel.Size = new System.Drawing.Size(103, 15);
            decodeInputLabel.TabIndex = 5;
            decodeInputLabel.Text = "Decode files from:";
            // 
            // decodeInputFile
            // 
            decodeInputFile.ForeColor = System.Drawing.Color.White;
            decodeInputFile.Location = new System.Drawing.Point(3, 29);
            decodeInputFile.Name = "decodeInputFile";
            decodeInputFile.Size = new System.Drawing.Size(398, 18);
            decodeInputFile.TabIndex = 9;
            decodeInputFile.Text = "InputFilePath";
            decodeInputFile.Visible = false;
            // 
            // decodeOutputLabel
            // 
            decodeOutputLabel.AutoSize = true;
            decodeOutputLabel.ForeColor = System.Drawing.Color.Transparent;
            decodeOutputLabel.Location = new System.Drawing.Point(1, 52);
            decodeOutputLabel.Name = "decodeOutputLabel";
            decodeOutputLabel.Size = new System.Drawing.Size(62, 15);
            decodeOutputLabel.TabIndex = 6;
            decodeOutputLabel.Text = "Output to:";
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.Green;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button4.ForeColor = System.Drawing.Color.White;
            button4.Location = new System.Drawing.Point(85, 48);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Browse";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // folderRadio
            // 
            folderRadio.AutoSize = true;
            folderRadio.ForeColor = System.Drawing.Color.White;
            folderRadio.Location = new System.Drawing.Point(11, 37);
            folderRadio.Name = "folderRadio";
            folderRadio.Size = new System.Drawing.Size(58, 19);
            folderRadio.TabIndex = 18;
            folderRadio.TabStop = true;
            folderRadio.Text = "Folder";
            folderRadio.UseVisualStyleBackColor = true;
            folderRadio.CheckedChanged += folderRadio_CheckedChanged;
            // 
            // fileRadio
            // 
            fileRadio.AutoSize = true;
            fileRadio.ForeColor = System.Drawing.Color.White;
            fileRadio.Location = new System.Drawing.Point(11, 12);
            fileRadio.Name = "fileRadio";
            fileRadio.Size = new System.Drawing.Size(43, 19);
            fileRadio.TabIndex = 19;
            fileRadio.TabStop = true;
            fileRadio.Text = "File";
            fileRadio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            fileRadio.UseVisualStyleBackColor = true;
            fileRadio.CheckedChanged += fileRadio_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(50, 52, 54);
            ClientSize = new System.Drawing.Size(928, 451);
            Controls.Add(encryptPanel);
            Controls.Add(decryptPanel);
            Controls.Add(fileRadio);
            Controls.Add(folderRadio);
            Controls.Add(LetsGo);
            Controls.Add(pictureBox1);
            Controls.Add(DecodeButton);
            Controls.Add(DecryptButton);
            Controls.Add(EncryptButton);
            Controls.Add(decodePanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(444, 490);
            MinimumSize = new System.Drawing.Size(444, 490);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AB360 Lua Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            encryptPanel.ResumeLayout(false);
            encryptPanel.PerformLayout();
            decryptPanel.ResumeLayout(false);
            decryptPanel.PerformLayout();
            decodePanel.ResumeLayout(false);
            decodePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label encryptInputLabel;
        private System.Windows.Forms.Label encryptOutputLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label encryptInputFile;
        private System.Windows.Forms.Panel encryptPanel;
        private System.Windows.Forms.ComboBox encryptGameSelect;
        private System.Windows.Forms.Label encryptOutputFile;
        private System.Windows.Forms.Label encryptBrotipLabel;
        private System.Windows.Forms.Button LetsGo;
        private System.Windows.Forms.Panel decryptPanel;
        private System.Windows.Forms.Button decryptInputFileButton;
        private System.Windows.Forms.Label decryptBrotipLabel;
        private System.Windows.Forms.CheckBox autoUnzip;
        private System.Windows.Forms.ComboBox decryptGameSelect;
        private System.Windows.Forms.Label decryptOutputFile;
        private System.Windows.Forms.Label decryptInputLabel;
        private System.Windows.Forms.Label decryptInputFile;
        private System.Windows.Forms.Label decryptOutputLabel;
        private System.Windows.Forms.Button decryptOutputFileButton;
        private System.Windows.Forms.Panel decodePanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label decodeBrotipLabel;
        private System.Windows.Forms.Label decodeOutputFile;
        private System.Windows.Forms.Label decodeInputLabel;
        private System.Windows.Forms.Label decodeInputFile;
        private System.Windows.Forms.Label decodeOutputLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.TextBox customKeyEnc;
        private System.Windows.Forms.RadioButton SevenZipCheck;
        private System.Windows.Forms.RadioButton LZMACheck;
        private System.Windows.Forms.RadioButton RawFileCheck;
        private System.Windows.Forms.CheckBox autoUnlzma;
        private System.Windows.Forms.TextBox customKeyDec;
        private System.Windows.Forms.RadioButton folderRadio;
        private System.Windows.Forms.RadioButton fileRadio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

