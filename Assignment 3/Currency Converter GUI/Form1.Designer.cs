namespace Currency_Converter_GUI {
    partial class Form1 {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.originalCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.OrignalCurrencyLabel = new System.Windows.Forms.Label();
            this.newCurrencyLabel = new System.Windows.Forms.Label();
            this.AmountIHaveLabel = new System.Windows.Forms.Label();
            this.AmountIWantLabel = new System.Windows.Forms.Label();
            this.newCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.CurrencyTextBox = new System.Windows.Forms.TextBox();
            this.ConvertedCurrencyTextBox = new System.Windows.Forms.TextBox();
            this.wantType = new System.Windows.Forms.Label();
            this.haveType = new System.Windows.Forms.Label();
            this.equalsButton = new System.Windows.Forms.Button();
            this.AnotherConversionGroupBox = new System.Windows.Forms.GroupBox();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.AnotherConversionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // originalCurrencyComboBox
            // 
            this.originalCurrencyComboBox.FormattingEnabled = true;
            this.originalCurrencyComboBox.Location = new System.Drawing.Point(51, 64);
            this.originalCurrencyComboBox.Name = "originalCurrencyComboBox";
            this.originalCurrencyComboBox.Size = new System.Drawing.Size(130, 21);
            this.originalCurrencyComboBox.TabIndex = 0;
            this.originalCurrencyComboBox.SelectedIndexChanged += new System.EventHandler(this.CurrencyHaveComboBox_SelectedIndexChanged);
            // 
            // OrignalCurrencyLabel
            // 
            this.OrignalCurrencyLabel.AutoSize = true;
            this.OrignalCurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrignalCurrencyLabel.Location = new System.Drawing.Point(48, 45);
            this.OrignalCurrencyLabel.Name = "OrignalCurrencyLabel";
            this.OrignalCurrencyLabel.Size = new System.Drawing.Size(115, 16);
            this.OrignalCurrencyLabel.TabIndex = 1;
            this.OrignalCurrencyLabel.Text = "Currency I have";
            // 
            // newCurrencyLabel
            // 
            this.newCurrencyLabel.AutoSize = true;
            this.newCurrencyLabel.Enabled = false;
            this.newCurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCurrencyLabel.Location = new System.Drawing.Point(267, 45);
            this.newCurrencyLabel.Name = "newCurrencyLabel";
            this.newCurrencyLabel.Size = new System.Drawing.Size(112, 16);
            this.newCurrencyLabel.TabIndex = 2;
            this.newCurrencyLabel.Text = "Currency I want";
            // 
            // AmountIHaveLabel
            // 
            this.AmountIHaveLabel.AutoSize = true;
            this.AmountIHaveLabel.Enabled = false;
            this.AmountIHaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountIHaveLabel.Location = new System.Drawing.Point(58, 182);
            this.AmountIHaveLabel.Name = "AmountIHaveLabel";
            this.AmountIHaveLabel.Size = new System.Drawing.Size(105, 16);
            this.AmountIHaveLabel.TabIndex = 3;
            this.AmountIHaveLabel.Text = "Amount I have";
            // 
            // AmountIWantLabel
            // 
            this.AmountIWantLabel.AutoSize = true;
            this.AmountIWantLabel.Enabled = false;
            this.AmountIWantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountIWantLabel.Location = new System.Drawing.Point(316, 182);
            this.AmountIWantLabel.Name = "AmountIWantLabel";
            this.AmountIWantLabel.Size = new System.Drawing.Size(102, 16);
            this.AmountIWantLabel.TabIndex = 4;
            this.AmountIWantLabel.Text = "Amount I want";
            // 
            // newCurrencyComboBox
            // 
            this.newCurrencyComboBox.Enabled = false;
            this.newCurrencyComboBox.FormattingEnabled = true;
            this.newCurrencyComboBox.Location = new System.Drawing.Point(270, 64);
            this.newCurrencyComboBox.Name = "newCurrencyComboBox";
            this.newCurrencyComboBox.Size = new System.Drawing.Size(130, 21);
            this.newCurrencyComboBox.TabIndex = 5;
            this.newCurrencyComboBox.SelectedIndexChanged += new System.EventHandler(this.CurrencyWantComboBox_SelectedIndexChanged);
            // 
            // CurrencyTextBox
            // 
            this.CurrencyTextBox.Enabled = false;
            this.CurrencyTextBox.Location = new System.Drawing.Point(61, 201);
            this.CurrencyTextBox.Name = "CurrencyTextBox";
            this.CurrencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.CurrencyTextBox.TabIndex = 6;
            this.CurrencyTextBox.TextChanged += new System.EventHandler(this.CurrencyTextBox_TextChanged);
            // 
            // ConvertedCurrencyTextBox
            // 
            this.ConvertedCurrencyTextBox.Enabled = false;
            this.ConvertedCurrencyTextBox.Location = new System.Drawing.Point(318, 201);
            this.ConvertedCurrencyTextBox.Name = "ConvertedCurrencyTextBox";
            this.ConvertedCurrencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConvertedCurrencyTextBox.TabIndex = 7;
            // 
            // wantType
            // 
            this.wantType.AutoSize = true;
            this.wantType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wantType.Location = new System.Drawing.Point(280, 202);
            this.wantType.Name = "wantType";
            this.wantType.Size = new System.Drawing.Size(0, 16);
            this.wantType.TabIndex = 8;
            // 
            // haveType
            // 
            this.haveType.AutoSize = true;
            this.haveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haveType.Location = new System.Drawing.Point(21, 202);
            this.haveType.Name = "haveType";
            this.haveType.Size = new System.Drawing.Size(0, 16);
            this.haveType.TabIndex = 9;
            // 
            // equalsButton
            // 
            this.equalsButton.Enabled = false;
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsButton.Location = new System.Drawing.Point(188, 127);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(75, 42);
            this.equalsButton.TabIndex = 10;
            this.equalsButton.Text = "equals";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // AnotherConversionGroupBox
            // 
            this.AnotherConversionGroupBox.Controls.Add(this.noRadioButton);
            this.AnotherConversionGroupBox.Controls.Add(this.yesRadioButton);
            this.AnotherConversionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnotherConversionGroupBox.Location = new System.Drawing.Point(188, 237);
            this.AnotherConversionGroupBox.Name = "AnotherConversionGroupBox";
            this.AnotherConversionGroupBox.Size = new System.Drawing.Size(200, 100);
            this.AnotherConversionGroupBox.TabIndex = 11;
            this.AnotherConversionGroupBox.TabStop = false;
            this.AnotherConversionGroupBox.Text = "Another Conversion?";
            this.AnotherConversionGroupBox.Visible = false;
            this.AnotherConversionGroupBox.Enter += new System.EventHandler(this.AnotherGroupBox_Enter);
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(7, 56);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(49, 24);
            this.noRadioButton.TabIndex = 1;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            this.noRadioButton.CheckedChanged += new System.EventHandler(this.AnotherGroupBox_Enter);
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(7, 26);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(58, 24);
            this.yesRadioButton.TabIndex = 0;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            this.yesRadioButton.CheckedChanged += new System.EventHandler(this.AnotherGroupBox_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 361);
            this.Controls.Add(this.AnotherConversionGroupBox);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.haveType);
            this.Controls.Add(this.wantType);
            this.Controls.Add(this.ConvertedCurrencyTextBox);
            this.Controls.Add(this.CurrencyTextBox);
            this.Controls.Add(this.newCurrencyComboBox);
            this.Controls.Add(this.AmountIWantLabel);
            this.Controls.Add(this.AmountIHaveLabel);
            this.Controls.Add(this.newCurrencyLabel);
            this.Controls.Add(this.OrignalCurrencyLabel);
            this.Controls.Add(this.originalCurrencyComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.AnotherConversionGroupBox.ResumeLayout(false);
            this.AnotherConversionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox originalCurrencyComboBox;
        private System.Windows.Forms.Label OrignalCurrencyLabel;
        private System.Windows.Forms.Label newCurrencyLabel;
        private System.Windows.Forms.Label AmountIHaveLabel;
        private System.Windows.Forms.Label AmountIWantLabel;
        private System.Windows.Forms.ComboBox newCurrencyComboBox;
        private System.Windows.Forms.TextBox CurrencyTextBox;
        private System.Windows.Forms.TextBox ConvertedCurrencyTextBox;
        private System.Windows.Forms.Label wantType;
        private System.Windows.Forms.Label haveType;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.GroupBox AnotherConversionGroupBox;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
    }
}

