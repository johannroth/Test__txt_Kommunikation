namespace Test__txt_Kommunikation
{
    partial class Gui
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.testTextButton = new System.Windows.Forms.Button();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.testTextLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.writeTimeButton = new System.Windows.Forms.Button();
            this.timeSinceLastWriteButton = new System.Windows.Forms.Button();
            this.writtenTimeLabel = new System.Windows.Forms.Label();
            this.timeSinceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(132, 45);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "test";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "write txt-file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testTextButton
            // 
            this.testTextButton.Location = new System.Drawing.Point(12, 265);
            this.testTextButton.Name = "testTextButton";
            this.testTextButton.Size = new System.Drawing.Size(141, 23);
            this.testTextButton.TabIndex = 2;
            this.testTextButton.Text = "write Text";
            this.testTextButton.UseVisualStyleBackColor = true;
            this.testTextButton.Click += new System.EventHandler(this.testTextButton_Click);
            // 
            // testTextBox
            // 
            this.testTextBox.Location = new System.Drawing.Point(168, 266);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(100, 22);
            this.testTextBox.TabIndex = 3;
            // 
            // testTextLabel
            // 
            this.testTextLabel.Location = new System.Drawing.Point(12, 295);
            this.testTextLabel.Name = "testTextLabel";
            this.testTextLabel.Size = new System.Drawing.Size(256, 23);
            this.testTextLabel.TabIndex = 4;
            this.testTextLabel.Text = "Text";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "open Options";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // writeTimeButton
            // 
            this.writeTimeButton.Location = new System.Drawing.Point(15, 191);
            this.writeTimeButton.Name = "writeTimeButton";
            this.writeTimeButton.Size = new System.Drawing.Size(138, 23);
            this.writeTimeButton.TabIndex = 6;
            this.writeTimeButton.Text = "writeTime";
            this.writeTimeButton.UseVisualStyleBackColor = true;
            this.writeTimeButton.Click += new System.EventHandler(this.writeTimeButton_Click);
            // 
            // timeSinceLastWriteButton
            // 
            this.timeSinceLastWriteButton.Location = new System.Drawing.Point(15, 220);
            this.timeSinceLastWriteButton.Name = "timeSinceLastWriteButton";
            this.timeSinceLastWriteButton.Size = new System.Drawing.Size(138, 23);
            this.timeSinceLastWriteButton.TabIndex = 7;
            this.timeSinceLastWriteButton.Text = "timeSinceLastWrite";
            this.timeSinceLastWriteButton.UseVisualStyleBackColor = true;
            this.timeSinceLastWriteButton.Click += new System.EventHandler(this.timeSinceLastWriteButton_Click);
            // 
            // writtenTimeLabel
            // 
            this.writtenTimeLabel.AutoSize = true;
            this.writtenTimeLabel.Location = new System.Drawing.Point(168, 196);
            this.writtenTimeLabel.Name = "writtenTimeLabel";
            this.writtenTimeLabel.Size = new System.Drawing.Size(115, 17);
            this.writtenTimeLabel.TabIndex = 8;
            this.writtenTimeLabel.Text = "writtenTimeLabel";
            // 
            // timeSinceLabel
            // 
            this.timeSinceLabel.AutoSize = true;
            this.timeSinceLabel.Location = new System.Drawing.Point(168, 226);
            this.timeSinceLabel.Name = "timeSinceLabel";
            this.timeSinceLabel.Size = new System.Drawing.Size(104, 17);
            this.timeSinceLabel.TabIndex = 9;
            this.timeSinceLabel.Text = "timeSinceLabel";
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.timeSinceLabel);
            this.Controls.Add(this.writtenTimeLabel);
            this.Controls.Add(this.timeSinceLastWriteButton);
            this.Controls.Add(this.writeTimeButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.testTextLabel);
            this.Controls.Add(this.testTextBox);
            this.Controls.Add(this.testTextButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gui";
            this.Text = "Gui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button testTextButton;
        private System.Windows.Forms.TextBox testTextBox;
        private System.Windows.Forms.Label testTextLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button writeTimeButton;
        private System.Windows.Forms.Button timeSinceLastWriteButton;
        private System.Windows.Forms.Label writtenTimeLabel;
        private System.Windows.Forms.Label timeSinceLabel;

    }
}

