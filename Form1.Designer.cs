namespace NFC_ACR122U_Reader_Writer
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
            this.BlockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.SubStatusTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.StatusColorLabel = new System.Windows.Forms.Label();
            this.textBlockReaderState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WriteButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.TextToWriteTextBox = new System.Windows.Forms.TextBox();
            this.ReadedTextTextBox = new System.Windows.Forms.TextBox();
            this.BlocNo = new System.Windows.Forms.Label();
            this.CardUIdTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // BlockNumericUpDown
            // 
            this.BlockNumericUpDown.Location = new System.Drawing.Point(130, 331);
            this.BlockNumericUpDown.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.BlockNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BlockNumericUpDown.Name = "BlockNumericUpDown";
            this.BlockNumericUpDown.Size = new System.Drawing.Size(349, 20);
            this.BlockNumericUpDown.TabIndex = 255;
            this.BlockNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 254;
            this.label3.Text = "Card Sub Status";
            // 
            // SubStatusTextBox
            // 
            this.SubStatusTextBox.Enabled = false;
            this.SubStatusTextBox.Location = new System.Drawing.Point(249, 118);
            this.SubStatusTextBox.Name = "SubStatusTextBox";
            this.SubStatusTextBox.Size = new System.Drawing.Size(230, 20);
            this.SubStatusTextBox.TabIndex = 253;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 252;
            this.label2.Text = "Card Status";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Enabled = false;
            this.StatusTextBox.Location = new System.Drawing.Point(16, 118);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(227, 20);
            this.StatusTextBox.TabIndex = 251;
            // 
            // StatusColorLabel
            // 
            this.StatusColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusColorLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.StatusColorLabel.Location = new System.Drawing.Point(1, 17);
            this.StatusColorLabel.Name = "StatusColorLabel";
            this.StatusColorLabel.Size = new System.Drawing.Size(491, 10);
            this.StatusColorLabel.TabIndex = 250;
            // 
            // textBlockReaderState
            // 
            this.textBlockReaderState.AutoSize = true;
            this.textBlockReaderState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBlockReaderState.Location = new System.Drawing.Point(16, 404);
            this.textBlockReaderState.Name = "textBlockReaderState";
            this.textBlockReaderState.Size = new System.Drawing.Size(36, 20);
            this.textBlockReaderState.TabIndex = 249;
            this.textBlockReaderState.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 248;
            this.label1.Text = "Block No";
            // 
            // WriteButton
            // 
            this.WriteButton.Location = new System.Drawing.Point(20, 253);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(88, 37);
            this.WriteButton.TabIndex = 247;
            this.WriteButton.Text = "Write";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(17, 195);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(88, 37);
            this.ReadButton.TabIndex = 246;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // TextToWriteTextBox
            // 
            this.TextToWriteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextToWriteTextBox.Location = new System.Drawing.Point(130, 257);
            this.TextToWriteTextBox.Name = "TextToWriteTextBox";
            this.TextToWriteTextBox.Size = new System.Drawing.Size(349, 26);
            this.TextToWriteTextBox.TabIndex = 245;
            // 
            // ReadedTextTextBox
            // 
            this.ReadedTextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadedTextTextBox.Location = new System.Drawing.Point(129, 199);
            this.ReadedTextTextBox.Name = "ReadedTextTextBox";
            this.ReadedTextTextBox.Size = new System.Drawing.Size(349, 26);
            this.ReadedTextTextBox.TabIndex = 244;
            // 
            // BlocNo
            // 
            this.BlocNo.AutoSize = true;
            this.BlocNo.Location = new System.Drawing.Point(16, 64);
            this.BlocNo.Name = "BlocNo";
            this.BlocNo.Size = new System.Drawing.Size(37, 13);
            this.BlocNo.TabIndex = 243;
            this.BlocNo.Text = "CARD";
            // 
            // CardUIdTextbox
            // 
            this.CardUIdTextbox.Enabled = false;
            this.CardUIdTextbox.Location = new System.Drawing.Point(16, 80);
            this.CardUIdTextbox.Name = "CardUIdTextbox";
            this.CardUIdTextbox.Size = new System.Drawing.Size(463, 20);
            this.CardUIdTextbox.TabIndex = 242;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.BlockNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubStatusTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.StatusColorLabel);
            this.Controls.Add(this.textBlockReaderState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WriteButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.TextToWriteTextBox);
            this.Controls.Add(this.ReadedTextTextBox);
            this.Controls.Add(this.BlocNo);
            this.Controls.Add(this.CardUIdTextbox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown BlockNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubStatusTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Label StatusColorLabel;
        private System.Windows.Forms.Label textBlockReaderState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.TextBox TextToWriteTextBox;
        private System.Windows.Forms.TextBox ReadedTextTextBox;
        private System.Windows.Forms.Label BlocNo;
        private System.Windows.Forms.TextBox CardUIdTextbox;
    }
}

