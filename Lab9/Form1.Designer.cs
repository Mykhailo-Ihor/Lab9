namespace ATMApplication
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlLanguage = new System.Windows.Forms.Panel();
            this.btnUkrainian = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.lblSelectLanguage = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlCardDetails = new System.Windows.Forms.Panel();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.lblEnterPIN = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblCVV = new System.Windows.Forms.Label();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.lblCurrentBank = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.pnlTransaction = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.pnlLanguage.SuspendLayout();
            this.pnlCardDetails.SuspendLayout();
            this.pnlMainMenu.SuspendLayout();
            this.pnlTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLanguage
            // 
            this.pnlLanguage.Controls.Add(this.btnUkrainian);
            this.pnlLanguage.Controls.Add(this.btnEnglish);
            this.pnlLanguage.Controls.Add(this.lblSelectLanguage);
            this.pnlLanguage.Controls.Add(this.lblWelcome);
            this.pnlLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLanguage.Location = new System.Drawing.Point(0, 0);
            this.pnlLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLanguage.Name = "pnlLanguage";
            this.pnlLanguage.Size = new System.Drawing.Size(1308, 606);
            this.pnlLanguage.TabIndex = 0;
            // 
            // btnUkrainian
            // 
            this.btnUkrainian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUkrainian.Location = new System.Drawing.Point(525, 150);
            this.btnUkrainian.Margin = new System.Windows.Forms.Padding(4);
            this.btnUkrainian.Name = "btnUkrainian";
            this.btnUkrainian.Size = new System.Drawing.Size(267, 49);
            this.btnUkrainian.TabIndex = 3;
            this.btnUkrainian.Text = "Українська";
            this.btnUkrainian.UseVisualStyleBackColor = true;
            this.btnUkrainian.Click += new System.EventHandler(this.btnUkrainian_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnglish.Location = new System.Drawing.Point(525, 207);
            this.btnEnglish.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(267, 49);
            this.btnEnglish.TabIndex = 2;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // lblSelectLanguage
            // 
            this.lblSelectLanguage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelectLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectLanguage.Location = new System.Drawing.Point(525, 117);
            this.lblSelectLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.lblSelectLanguage.Name = "lblSelectLanguage";
            this.lblSelectLanguage.Size = new System.Drawing.Size(267, 25);
            this.lblSelectLanguage.TabIndex = 1;
            this.lblSelectLanguage.Text = "Select language:";
            this.lblSelectLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSelectLanguage.Click += new System.EventHandler(this.lblSelectLanguage_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(410, 84);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcome.Size = new System.Drawing.Size(500, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "PrivatBank ATM";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // pnlCardDetails
            // 
            this.pnlCardDetails.Controls.Add(this.btnBack2);
            this.pnlCardDetails.Controls.Add(this.btnValidate);
            this.pnlCardDetails.Controls.Add(this.txtPIN);
            this.pnlCardDetails.Controls.Add(this.lblEnterPIN);
            this.pnlCardDetails.Controls.Add(this.txtCVV);
            this.pnlCardDetails.Controls.Add(this.lblCVV);
            this.pnlCardDetails.Controls.Add(this.txtExpiryDate);
            this.pnlCardDetails.Controls.Add(this.lblExpiryDate);
            this.pnlCardDetails.Controls.Add(this.txtCardNumber);
            this.pnlCardDetails.Controls.Add(this.lblCardNumber);
            this.pnlCardDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlCardDetails.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCardDetails.Name = "pnlCardDetails";
            this.pnlCardDetails.Size = new System.Drawing.Size(1308, 606);
            this.pnlCardDetails.TabIndex = 1;
            this.pnlCardDetails.Visible = false;
            // 
            // btnBack2
            // 
            this.btnBack2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack2.Location = new System.Drawing.Point(525, 426);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(267, 49);
            this.btnBack2.TabIndex = 9;
            this.btnBack2.Text = "Back\r\n";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnValidate.Location = new System.Drawing.Point(525, 370);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(267, 49);
            this.btnValidate.TabIndex = 8;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtPIN
            // 
            this.txtPIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPIN.Location = new System.Drawing.Point(525, 324);
            this.txtPIN.Margin = new System.Windows.Forms.Padding(4);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.PasswordChar = '*';
            this.txtPIN.Size = new System.Drawing.Size(265, 22);
            this.txtPIN.TabIndex = 7;
            // 
            // lblEnterPIN
            // 
            this.lblEnterPIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnterPIN.AutoSize = true;
            this.lblEnterPIN.Location = new System.Drawing.Point(525, 304);
            this.lblEnterPIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterPIN.Name = "lblEnterPIN";
            this.lblEnterPIN.Size = new System.Drawing.Size(100, 16);
            this.lblEnterPIN.TabIndex = 6;
            this.lblEnterPIN.Text = "Enter PIN code:";
            // 
            // txtCVV
            // 
            this.txtCVV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCVV.Location = new System.Drawing.Point(525, 264);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(4);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.PasswordChar = '*';
            this.txtCVV.Size = new System.Drawing.Size(265, 22);
            this.txtCVV.TabIndex = 5;
            // 
            // lblCVV
            // 
            this.lblCVV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCVV.AutoSize = true;
            this.lblCVV.Location = new System.Drawing.Point(525, 247);
            this.lblCVV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(71, 16);
            this.lblCVV.TabIndex = 4;
            this.lblCVV.Text = "CVV code:";
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtExpiryDate.Location = new System.Drawing.Point(525, 207);
            this.txtExpiryDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(265, 22);
            this.txtExpiryDate.TabIndex = 3;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(525, 188);
            this.lblExpiryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(132, 16);
            this.lblExpiryDate.TabIndex = 2;
            this.lblExpiryDate.Text = "Expiry date (MM/YY):";
            this.lblExpiryDate.Click += new System.EventHandler(this.lblExpiryDate_Click);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCardNumber.Location = new System.Drawing.Point(525, 150);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(265, 22);
            this.txtCardNumber.TabIndex = 1;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(525, 130);
            this.lblCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(87, 16);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card number:";
            this.lblCardNumber.Click += new System.EventHandler(this.lblCardNumber_Click);
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.Controls.Add(this.lblCurrentBalance);
            this.pnlMainMenu.Controls.Add(this.lblCurrentBank);
            this.pnlMainMenu.Controls.Add(this.btnExit);
            this.pnlMainMenu.Controls.Add(this.btnPrintReceipt);
            this.pnlMainMenu.Controls.Add(this.btnDeposit);
            this.pnlMainMenu.Controls.Add(this.btnWithdraw);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(1308, 606);
            this.pnlMainMenu.TabIndex = 2;
            this.pnlMainMenu.Visible = false;
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalance.Location = new System.Drawing.Point(525, 117);
            this.lblCurrentBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(157, 25);
            this.lblCurrentBalance.TabIndex = 6;
            this.lblCurrentBalance.Text = "Current balance:";
            // 
            // lblCurrentBank
            // 
            this.lblCurrentBank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentBank.AutoSize = true;
            this.lblCurrentBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBank.Location = new System.Drawing.Point(525, 84);
            this.lblCurrentBank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentBank.Name = "lblCurrentBank";
            this.lblCurrentBank.Size = new System.Drawing.Size(147, 29);
            this.lblCurrentBank.TabIndex = 5;
            this.lblCurrentBank.Text = "Bank Name";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Location = new System.Drawing.Point(525, 324);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(267, 49);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrintReceipt.Location = new System.Drawing.Point(525, 267);
            this.btnPrintReceipt.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(267, 49);
            this.btnPrintReceipt.TabIndex = 3;
            this.btnPrintReceipt.Text = "Print receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeposit.Location = new System.Drawing.Point(525, 207);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(267, 49);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWithdraw.Location = new System.Drawing.Point(525, 150);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(267, 49);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // pnlTransaction
            // 
            this.pnlTransaction.Controls.Add(this.btnBack);
            this.pnlTransaction.Controls.Add(this.btnConfirm);
            this.pnlTransaction.Controls.Add(this.txtAmount);
            this.pnlTransaction.Controls.Add(this.lblAmount);
            this.pnlTransaction.Controls.Add(this.lblTransactionType);
            this.pnlTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransaction.Location = new System.Drawing.Point(0, 0);
            this.pnlTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTransaction.Name = "pnlTransaction";
            this.pnlTransaction.Size = new System.Drawing.Size(1308, 606);
            this.pnlTransaction.TabIndex = 3;
            this.pnlTransaction.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Location = new System.Drawing.Point(525, 283);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(267, 49);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.Location = new System.Drawing.Point(525, 222);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(267, 49);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmount.Location = new System.Drawing.Point(525, 185);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(265, 22);
            this.txtAmount.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(525, 165);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(55, 16);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount:";
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionType.Location = new System.Drawing.Point(525, 130);
            this.lblTransactionType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(121, 29);
            this.lblTransactionType.TabIndex = 0;
            this.lblTransactionType.Text = "Withdraw";
            this.lblTransactionType.Click += new System.EventHandler(this.lblTransactionType_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 606);
            this.Controls.Add(this.pnlLanguage);
            this.Controls.Add(this.pnlCardDetails);
            this.Controls.Add(this.pnlMainMenu);
            this.Controls.Add(this.pnlTransaction);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "ATM Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlLanguage.ResumeLayout(false);
            this.pnlCardDetails.ResumeLayout(false);
            this.pnlCardDetails.PerformLayout();
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            this.pnlTransaction.ResumeLayout(false);
            this.pnlTransaction.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlLanguage;
        private System.Windows.Forms.Button btnUkrainian;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlCardDetails;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label lblEnterPIN;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Label lblCurrentBank;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Panel pnlTransaction;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTransactionType;
        private System.Windows.Forms.Label lblSelectLanguage;
        private System.Windows.Forms.Button btnBack2;
    }
}