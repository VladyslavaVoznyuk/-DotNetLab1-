namespace WinForm
{
    partial class AuthorizationForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BalanceTextBox = new System.Windows.Forms.TextBox();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.CardPINTextBox = new System.Windows.Forms.TextBox();
            this.CardPINLabel = new System.Windows.Forms.Label();
            this.CardNumberTextBox = new System.Windows.Forms.TextBox();
            this.CardNumberLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AuthorizeButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.DimGray;
            this.MainPanel.Controls.Add(this.BalanceTextBox);
            this.MainPanel.Controls.Add(this.BalanceLabel);
            this.MainPanel.Controls.Add(this.CardPINTextBox);
            this.MainPanel.Controls.Add(this.CardPINLabel);
            this.MainPanel.Controls.Add(this.CardNumberTextBox);
            this.MainPanel.Controls.Add(this.CardNumberLabel);
            this.MainPanel.Controls.Add(this.NameTextBox);
            this.MainPanel.Controls.Add(this.NameLabel);
            this.MainPanel.Controls.Add(this.AuthorizeButton);
            this.MainPanel.Controls.Add(this.CancelButton);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(387, 321);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthorizationForm_MouseDown);
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.Location = new System.Drawing.Point(3, 203);
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.Size = new System.Drawing.Size(384, 30);
            this.BalanceTextBox.TabIndex = 25;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(123, 177);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(127, 25);
            this.BalanceLabel.TabIndex = 24;
            this.BalanceLabel.Text = "Баланс в грн";
            // 
            // CardPINTextBox
            // 
            this.CardPINTextBox.Location = new System.Drawing.Point(3, 144);
            this.CardPINTextBox.Name = "CardPINTextBox";
            this.CardPINTextBox.Size = new System.Drawing.Size(381, 30);
            this.CardPINTextBox.TabIndex = 23;
            // 
            // CardPINLabel
            // 
            this.CardPINLabel.AutoSize = true;
            this.CardPINLabel.Location = new System.Drawing.Point(132, 118);
            this.CardPINLabel.Name = "CardPINLabel";
            this.CardPINLabel.Size = new System.Drawing.Size(85, 25);
            this.CardPINLabel.TabIndex = 22;
            this.CardPINLabel.Text = "Pin-код ";
            // 
            // CardNumberTextBox
            // 
            this.CardNumberTextBox.Location = new System.Drawing.Point(3, 85);
            this.CardNumberTextBox.Name = "CardNumberTextBox";
            this.CardNumberTextBox.Size = new System.Drawing.Size(384, 30);
            this.CardNumberTextBox.TabIndex = 21;
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.AutoSize = true;
            this.CardNumberLabel.Location = new System.Drawing.Point(123, 59);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.Size = new System.Drawing.Size(134, 25);
            this.CardNumberLabel.TabIndex = 20;
            this.CardNumberLabel.Text = "Номер карти";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(3, 26);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(384, 30);
            this.NameTextBox.TabIndex = 19;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(152, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 25);
            this.NameLabel.TabIndex = 18;
            this.NameLabel.Text = "Ім\'я";
            // 
            // AuthorizeButton
            // 
            this.AuthorizeButton.BackColor = System.Drawing.Color.Chartreuse;
            this.AuthorizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthorizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AuthorizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorizeButton.ForeColor = System.Drawing.Color.White;
            this.AuthorizeButton.Location = new System.Drawing.Point(75, 250);
            this.AuthorizeButton.Name = "AuthorizeButton";
            this.AuthorizeButton.Size = new System.Drawing.Size(226, 31);
            this.AuthorizeButton.TabIndex = 17;
            this.AuthorizeButton.Text = "Авторизація";
            this.AuthorizeButton.UseVisualStyleBackColor = false;
            this.AuthorizeButton.Click += new System.EventHandler(this.AuthorizeButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Firebrick;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(75, 287);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(226, 31);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Відмінити";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(411, 345);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthorizationForm_MouseDown);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button AuthorizeButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox BalanceTextBox;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.TextBox CardPINTextBox;
        private System.Windows.Forms.Label CardPINLabel;
        private System.Windows.Forms.TextBox CardNumberTextBox;
        private System.Windows.Forms.Label CardNumberLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
    }
}

