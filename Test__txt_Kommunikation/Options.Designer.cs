namespace Test__txt_Kommunikation
{
    partial class Options
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
            this.hideButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.selectedFileTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkPathButton = new System.Windows.Forms.Button();
            this.checkPathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hideButton
            // 
            this.hideButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.hideButton.Location = new System.Drawing.Point(42, 34);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(75, 23);
            this.hideButton.TabIndex = 0;
            this.hideButton.Text = "Close";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(42, 173);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(75, 23);
            this.selectFileButton.TabIndex = 3;
            this.selectFileButton.Text = "selectFile";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // selectedFileTextBox
            // 
            this.selectedFileTextBox.Location = new System.Drawing.Point(141, 174);
            this.selectedFileTextBox.Name = "selectedFileTextBox";
            this.selectedFileTextBox.Size = new System.Drawing.Size(100, 22);
            this.selectedFileTextBox.TabIndex = 4;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Hier bitte einen Zielordner wählen.";
            this.folderBrowserDialog1.SelectedPath = "D:\\Git-Repos\\Test__txt_Kommunikation\\Test__txt_Kommunikation";
            // 
            // checkPathButton
            // 
            this.checkPathButton.Location = new System.Drawing.Point(42, 221);
            this.checkPathButton.Name = "checkPathButton";
            this.checkPathButton.Size = new System.Drawing.Size(75, 23);
            this.checkPathButton.TabIndex = 5;
            this.checkPathButton.Text = "Path Ok?";
            this.checkPathButton.UseVisualStyleBackColor = true;
            this.checkPathButton.Click += new System.EventHandler(this.checkPathButton_Click);
            // 
            // checkPathLabel
            // 
            this.checkPathLabel.AutoSize = true;
            this.checkPathLabel.Location = new System.Drawing.Point(124, 226);
            this.checkPathLabel.Name = "checkPathLabel";
            this.checkPathLabel.Size = new System.Drawing.Size(46, 17);
            this.checkPathLabel.TabIndex = 6;
            this.checkPathLabel.Text = "label2";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.hideButton;
            this.ClientSize = new System.Drawing.Size(666, 337);
            this.Controls.Add(this.checkPathLabel);
            this.Controls.Add(this.checkPathButton);
            this.Controls.Add(this.selectedFileTextBox);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.hideButton);
            this.MaximizeBox = false;
            this.Name = "Options";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox selectedFileTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button checkPathButton;
        private System.Windows.Forms.Label checkPathLabel;
    }
}