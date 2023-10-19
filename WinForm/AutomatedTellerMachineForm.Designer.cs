namespace WinForm
{
    partial class AutomatedTellerMachineForm
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
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MachineCheckBalanceButton = new System.Windows.Forms.Button();
            this.MachineAddressLabel = new System.Windows.Forms.Label();
            this.MachineIDLabel = new System.Windows.Forms.Label();
            this.BankAddressLabel = new System.Windows.Forms.Label();
            this.BankNameLabel = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.CardNumberTextLabel = new System.Windows.Forms.Label();
            this.CardCheckBalanceButton = new System.Windows.Forms.Button();
            this.SumTextLabel = new System.Windows.Forms.Label();
            this.TransferCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.TransferSumTextBox = new System.Windows.Forms.TextBox();
            this.WithdrawSumTextBox = new System.Windows.Forms.TextBox();
            this.PutSumTextBox = new System.Windows.Forms.TextBox();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.TransferButton = new System.Windows.Forms.Button();
            this.PutButton = new System.Windows.Forms.Button();
            this.AccountCardNumberLabel = new System.Windows.Forms.Label();
            this.AccountNameLabel = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Black;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(690, 165);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(226, 31);
            this.MinimizeButton.TabIndex = 19;
            this.MinimizeButton.Text = "Звернути";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Black;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(690, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(226, 31);
            this.CloseButton.TabIndex = 18;
            this.CloseButton.Text = "Закрити";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TopPanel.Controls.Add(this.MachineCheckBalanceButton);
            this.TopPanel.Controls.Add(this.MachineAddressLabel);
            this.TopPanel.Controls.Add(this.MachineIDLabel);
            this.TopPanel.Controls.Add(this.BankAddressLabel);
            this.TopPanel.Controls.Add(this.BankNameLabel);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.MinimizeButton);
            this.TopPanel.Location = new System.Drawing.Point(12, 12);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(919, 202);
            this.TopPanel.TabIndex = 20;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AutomatedTellerMachineForm_MouseDown);
            // 
            // MachineCheckBalanceButton
            // 
            this.MachineCheckBalanceButton.BackColor = System.Drawing.Color.White;
            this.MachineCheckBalanceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MachineCheckBalanceButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MachineCheckBalanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MachineCheckBalanceButton.ForeColor = System.Drawing.Color.Black;
            this.MachineCheckBalanceButton.Location = new System.Drawing.Point(690, 85);
            this.MachineCheckBalanceButton.Name = "MachineCheckBalanceButton";
            this.MachineCheckBalanceButton.Size = new System.Drawing.Size(226, 31);
            this.MachineCheckBalanceButton.TabIndex = 33;
            this.MachineCheckBalanceButton.Text = "Переглянути баланс";
            this.MachineCheckBalanceButton.UseVisualStyleBackColor = false;
            this.MachineCheckBalanceButton.Click += new System.EventHandler(this.MachineCheckBalanceButton_Click);
            // 
            // MachineAddressLabel
            // 
            this.MachineAddressLabel.AutoSize = true;
            this.MachineAddressLabel.Location = new System.Drawing.Point(3, 70);
            this.MachineAddressLabel.Name = "MachineAddressLabel";
            this.MachineAddressLabel.Size = new System.Drawing.Size(0, 25);
            this.MachineAddressLabel.TabIndex = 24;
            // 
            // MachineIDLabel
            // 
            this.MachineIDLabel.AutoSize = true;
            this.MachineIDLabel.Location = new System.Drawing.Point(3, 51);
            this.MachineIDLabel.Name = "MachineIDLabel";
            this.MachineIDLabel.Size = new System.Drawing.Size(0, 25);
            this.MachineIDLabel.TabIndex = 23;
            // 
            // BankAddressLabel
            // 
            this.BankAddressLabel.AutoSize = true;
            this.BankAddressLabel.Location = new System.Drawing.Point(3, 22);
            this.BankAddressLabel.Name = "BankAddressLabel";
            this.BankAddressLabel.Size = new System.Drawing.Size(0, 25);
            this.BankAddressLabel.TabIndex = 22;
            // 
            // BankNameLabel
            // 
            this.BankNameLabel.AutoSize = true;
            this.BankNameLabel.Location = new System.Drawing.Point(3, 3);
            this.BankNameLabel.Name = "BankNameLabel";
            this.BankNameLabel.Size = new System.Drawing.Size(0, 25);
            this.BankNameLabel.TabIndex = 21;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomPanel.Controls.Add(this.CardNumberTextLabel);
            this.BottomPanel.Controls.Add(this.CardCheckBalanceButton);
            this.BottomPanel.Controls.Add(this.SumTextLabel);
            this.BottomPanel.Controls.Add(this.TransferCardNumberTextBox);
            this.BottomPanel.Controls.Add(this.TransferSumTextBox);
            this.BottomPanel.Controls.Add(this.WithdrawSumTextBox);
            this.BottomPanel.Controls.Add(this.PutSumTextBox);
            this.BottomPanel.Controls.Add(this.WithdrawButton);
            this.BottomPanel.Controls.Add(this.TransferButton);
            this.BottomPanel.Controls.Add(this.PutButton);
            this.BottomPanel.Controls.Add(this.AccountCardNumberLabel);
            this.BottomPanel.Controls.Add(this.AccountNameLabel);
            this.BottomPanel.Location = new System.Drawing.Point(12, 214);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(919, 305);
            this.BottomPanel.TabIndex = 21;
            this.BottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AutomatedTellerMachineForm_MouseDown);
            // 
            // CardNumberTextLabel
            // 
            this.CardNumberTextLabel.AutoSize = true;
            this.CardNumberTextLabel.Location = new System.Drawing.Point(0, 177);
            this.CardNumberTextLabel.Name = "CardNumberTextLabel";
            this.CardNumberTextLabel.Size = new System.Drawing.Size(140, 25);
            this.CardNumberTextLabel.TabIndex = 35;
            this.CardNumberTextLabel.Text = "Номер карти:";
            // 
            // CardCheckBalanceButton
            // 
            this.CardCheckBalanceButton.BackColor = System.Drawing.Color.White;
            this.CardCheckBalanceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CardCheckBalanceButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CardCheckBalanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CardCheckBalanceButton.ForeColor = System.Drawing.Color.Black;
            this.CardCheckBalanceButton.Location = new System.Drawing.Point(690, 171);
            this.CardCheckBalanceButton.Name = "CardCheckBalanceButton";
            this.CardCheckBalanceButton.Size = new System.Drawing.Size(226, 31);
            this.CardCheckBalanceButton.TabIndex = 34;
            this.CardCheckBalanceButton.Text = "Переглянути баланс";
            this.CardCheckBalanceButton.UseVisualStyleBackColor = false;
            this.CardCheckBalanceButton.Click += new System.EventHandler(this.CardCheckBalanceButton_Click);
            // 
            // SumTextLabel
            // 
            this.SumTextLabel.AutoSize = true;
            this.SumTextLabel.Location = new System.Drawing.Point(3, 236);
            this.SumTextLabel.Name = "SumTextLabel";
            this.SumTextLabel.Size = new System.Drawing.Size(67, 25);
            this.SumTextLabel.TabIndex = 31;
            this.SumTextLabel.Text = "Сума:";
            // 
            // TransferCardNumberTextBox
            // 
            this.TransferCardNumberTextBox.Location = new System.Drawing.Point(392, 177);
            this.TransferCardNumberTextBox.Name = "TransferCardNumberTextBox";
            this.TransferCardNumberTextBox.Size = new System.Drawing.Size(226, 30);
            this.TransferCardNumberTextBox.TabIndex = 30;
            // 
            // TransferSumTextBox
            // 
            this.TransferSumTextBox.Location = new System.Drawing.Point(690, 233);
            this.TransferSumTextBox.Name = "TransferSumTextBox";
            this.TransferSumTextBox.Size = new System.Drawing.Size(226, 30);
            this.TransferSumTextBox.TabIndex = 29;
            // 
            // WithdrawSumTextBox
            // 
            this.WithdrawSumTextBox.Location = new System.Drawing.Point(392, 236);
            this.WithdrawSumTextBox.Name = "WithdrawSumTextBox";
            this.WithdrawSumTextBox.Size = new System.Drawing.Size(226, 30);
            this.WithdrawSumTextBox.TabIndex = 28;
            // 
            // PutSumTextBox
            // 
            this.PutSumTextBox.Location = new System.Drawing.Point(76, 231);
            this.PutSumTextBox.Name = "PutSumTextBox";
            this.PutSumTextBox.Size = new System.Drawing.Size(226, 30);
            this.PutSumTextBox.TabIndex = 27;
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.BackColor = System.Drawing.Color.DarkGreen;
            this.WithdrawButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WithdrawButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.WithdrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WithdrawButton.ForeColor = System.Drawing.Color.White;
            this.WithdrawButton.Location = new System.Drawing.Point(392, 271);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(226, 31);
            this.WithdrawButton.TabIndex = 25;
            this.WithdrawButton.Text = "Зняти";
            this.WithdrawButton.UseVisualStyleBackColor = false;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // TransferButton
            // 
            this.TransferButton.BackColor = System.Drawing.Color.Black;
            this.TransferButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransferButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TransferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferButton.ForeColor = System.Drawing.Color.White;
            this.TransferButton.Location = new System.Drawing.Point(690, 271);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(226, 31);
            this.TransferButton.TabIndex = 26;
            this.TransferButton.Text = "Переслати";
            this.TransferButton.UseVisualStyleBackColor = false;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // PutButton
            // 
            this.PutButton.BackColor = System.Drawing.Color.Black;
            this.PutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PutButton.ForeColor = System.Drawing.Color.White;
            this.PutButton.Location = new System.Drawing.Point(75, 271);
            this.PutButton.Name = "PutButton";
            this.PutButton.Size = new System.Drawing.Size(226, 31);
            this.PutButton.TabIndex = 25;
            this.PutButton.Text = "Додати";
            this.PutButton.UseVisualStyleBackColor = false;
            this.PutButton.Click += new System.EventHandler(this.PutButton_Click);
            // 
            // AccountCardNumberLabel
            // 
            this.AccountCardNumberLabel.AutoSize = true;
            this.AccountCardNumberLabel.Location = new System.Drawing.Point(3, 26);
            this.AccountCardNumberLabel.Name = "AccountCardNumberLabel";
            this.AccountCardNumberLabel.Size = new System.Drawing.Size(0, 25);
            this.AccountCardNumberLabel.TabIndex = 21;
            // 
            // AccountNameLabel
            // 
            this.AccountNameLabel.AutoSize = true;
            this.AccountNameLabel.Location = new System.Drawing.Point(3, 3);
            this.AccountNameLabel.Name = "AccountNameLabel";
            this.AccountNameLabel.Size = new System.Drawing.Size(0, 25);
            this.AccountNameLabel.TabIndex = 20;
            // 
            // AutomatedTellerMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(943, 531);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AutomatedTellerMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutomatedTellerMachineForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AutomatedTellerMachineForm_MouseDown);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.TextBox PutSumTextBox;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.Button PutButton;
        private System.Windows.Forms.TextBox TransferCardNumberTextBox;
        private System.Windows.Forms.TextBox TransferSumTextBox;
        private System.Windows.Forms.TextBox WithdrawSumTextBox;
        private System.Windows.Forms.Label SumTextLabel;
        private System.Windows.Forms.Button MachineCheckBalanceButton;
        private System.Windows.Forms.Button CardCheckBalanceButton;
        private System.Windows.Forms.Label CardNumberTextLabel;
        public System.Windows.Forms.Label BankAddressLabel;
        public System.Windows.Forms.Label BankNameLabel;
        public System.Windows.Forms.Label AccountNameLabel;
        public System.Windows.Forms.Label MachineAddressLabel;
        public System.Windows.Forms.Label MachineIDLabel;
        public System.Windows.Forms.Label AccountCardNumberLabel;
    }
}