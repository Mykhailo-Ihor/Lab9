using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json;
using System.Data.SqlClient;


namespace ATMApplication
{
    public partial class MainForm : Form
    {
        private Bank _atmBank;
        private List<Bank> banks = new List<Bank>();
        private Card currentCard = null;
        private string selectedLanguage = "en-US";
        private decimal _initialBalance;
        private Dictionary<string, Dictionary<string, string>> translations = new Dictionary<string, Dictionary<string, string>>();

        public MainForm()
        {
            LoadBanks();
            InitializeComponent();
            InitializeLanguages();
            UpdateUI();
            pnlLanguage.Visible = true;
            pnlCardDetails.Visible = false;
            pnlMainMenu.Visible = false;
            pnlTransaction.Visible = false;
        }

        private void InitializeLanguages()
        {
            translations["uk-UA"] = new Dictionary<string, string>
            {
                {"Welcome", $"Банкомат {_atmBank.Name}"},
                {"SelectLanguage", "Оберіть мову:"},
                {"EnterCardDetails", "Введіть дані картки"},
                {"CardNumber", "Номер картки:"},
                {"ExpiryDate", "Термін дії (ММ/РР):"},
                {"CVV", "CVV код:"},
                {"EnterPIN", "Введіть PIN код:"},
                {"Validate", "Перевірити"},
                {"Balance", "Баланс"},
                {"Withdraw", "Зняти кошти"},
                {"Deposit", "Поповнити рахунок"},
                {"PrintReceipt", "Друкувати чек"},
                {"Exit", "Вийти"},
                {"Amount", "Сума:"},
                {"Confirm", "Підтвердити"},
                {"Back", "Назад"},
                {"InvalidCard", "Невірні дані картки"},
                {"InvalidPIN", "Невірний PIN код"},
                {"InsufficientFunds", "Недостатньо коштів"},
                {"Commission", "Комісія: {0}%"},
                {"CurrentBalance", "Поточний баланс: {0}"},
                {"TransactionCompleted", "Операція успішно виконана"},
                {"ReceiptPrinted", "Чек надруковано у файл: {0}"}
            };

            translations["en-US"] = new Dictionary<string, string>
            {
                {"Welcome",  $"{_atmBank.Name} ATM"},
                {"SelectLanguage", "Select language:"},
                {"EnterCardDetails", "Enter card details"},
                {"CardNumber", "Card number:"},
                {"ExpiryDate", "Expiry date (MM/YY):"},
                {"CVV", "CVV code:"},
                {"EnterPIN", "Enter PIN code:"},
                {"Validate", "Validate"},
                {"Balance", "Balance"},
                {"Withdraw", "Withdraw"},
                {"Deposit", "Deposit"},
                {"PrintReceipt", "Print receipt"},
                {"Exit", "Exit"},
                {"Amount", "Amount:"},
                {"Confirm", "Confirm"},
                {"Back", "Back"},
                {"InvalidCard", "Invalid card data"},
                {"InvalidPIN", "Invalid PIN code"},
                {"InsufficientFunds", "Insufficient funds"},
                {"Commission", "Commission: {0}%"},
                {"CurrentBalance", "Current balance: {0}"},
                {"TransactionCompleted", "Transaction completed successfully"},
                {"ReceiptPrinted", "Receipt printed to file: {0}"}
            };
        }

        private void LoadBanks()
        {
            try
            {
                string banksPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Banks");

                if (!Directory.Exists(banksPath))
                {
                    Directory.CreateDirectory(banksPath);
                    CreateSampleBank();
                }

                string[] bankFiles = Directory.GetFiles(banksPath, "*.xml");
                if (bankFiles.Length == 0)
                {
                    CreateSampleBank();
                    bankFiles = Directory.GetFiles(banksPath, "*.xml");
                }
                XmlSerializer serializer = new XmlSerializer(typeof(Bank));
                using (FileStream stream = new FileStream(bankFiles[0], FileMode.Open))
                {
                    _atmBank = (Bank)serializer.Deserialize(stream);
                    banks.Add(_atmBank);
                }

                for (int i = 1; i < bankFiles.Length; i++)
                {
                    using (FileStream stream = new FileStream(bankFiles[i], FileMode.Open))
                    {
                        Bank bank = (Bank)serializer.Deserialize(stream);
                        banks.Add(bank);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження банків: {ex.Message}");
            }
        }

        private void CreateSampleBank()
        {
            Bank sampleBank = new Bank
            {
                Name = "OtherBank",
                Commission = 1.5m,
                Cards = new List<Card>
        {
            new Card
            {
                CardNumber = "1234567890123456",
                ExpiryDate = "12/25",
                CVV = "123",
                PIN = "1234",
                Balance = 10000,
                BankName = "OtherBank"
            }
        }
            };

            XmlSerializer serializer = new XmlSerializer(typeof(Bank));
            using (FileStream stream = new FileStream("Banks/OtherBank.xml", FileMode.Create))
            {
                serializer.Serialize(stream, sampleBank);
            }
        }

        private void UpdateUI()
        {
            CultureInfo culture = new CultureInfo(selectedLanguage);
            Thread.CurrentThread.CurrentUICulture = culture;

            lblWelcome.Text = translations[selectedLanguage]["Welcome"];
            lblSelectLanguage.Text = translations[selectedLanguage]["SelectLanguage"];
            lblCardNumber.Text = translations[selectedLanguage]["CardNumber"];
            lblExpiryDate.Text = translations[selectedLanguage]["ExpiryDate"];
            lblCVV.Text = translations[selectedLanguage]["CVV"];
            lblEnterPIN.Text = translations[selectedLanguage]["EnterPIN"];
            btnValidate.Text = translations[selectedLanguage]["Validate"];
            btnWithdraw.Text = translations[selectedLanguage]["Withdraw"];
            btnDeposit.Text = translations[selectedLanguage]["Deposit"];
            btnPrintReceipt.Text = translations[selectedLanguage]["PrintReceipt"];
            btnExit.Text = translations[selectedLanguage]["Exit"];
            lblAmount.Text = translations[selectedLanguage]["Amount"];
            btnConfirm.Text = translations[selectedLanguage]["Confirm"];
            btnBack.Text = translations[selectedLanguage]["Back"];
            btnBack2.Text = translations[selectedLanguage]["Back"];
        }

        private void LogAction(string action)
        {
            try
            {
                string logEntry = $"{DateTime.Now} - {action}\n";
                File.AppendAllText("atm_log.txt", logEntry);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to log: {ex.Message}");
            }
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            selectedLanguage = "en-US";
            UpdateUI();
            LogAction("Language changed to English");
            pnlLanguage.Visible = false;
            pnlCardDetails.Visible = true;  
        }

        private void btnUkrainian_Click(object sender, EventArgs e)
        {
            selectedLanguage = "uk-UA";
            UpdateUI();
            LogAction("Language changed to Ukrainian");
            pnlLanguage.Visible = false;
            pnlCardDetails.Visible = true; 
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string cardNumber = txtCardNumber.Text.Replace(" ", "");
            string expiryDate = txtExpiryDate.Text;
            string cvv = txtCVV.Text;
            string pin = txtPIN.Text;

            currentCard = null;
            foreach (var bank in banks)
            {
                foreach (var card in bank.Cards)
                {

                    if (card.CardNumber == cardNumber &&
                        card.ExpiryDate == expiryDate &&
                        card.CVV == cvv &&
                        card.PIN == pin)
                    {
                        currentCard = card;
                        break;
                    }
                }
                if (currentCard != null) { _initialBalance = currentCard.Balance; break; }
            }

            if (currentCard == null)
            {
                MessageBox.Show(translations[selectedLanguage]["InvalidCard"]);
                LogAction("Card validation failed");
                return;
            }


            LogAction($"Card validated successfully for {currentCard.BankName} card ending with {cardNumber.Substring(12)}");
            ShowMainMenu();
        }

        private void ShowMainMenu()
        {
            pnlLanguage.Visible = false;
            pnlCardDetails.Visible = false;
            pnlMainMenu.Visible = true;
            lblCurrentBank.Text = _atmBank.Name;
            lblCurrentBalance.Text = string.Format(translations[selectedLanguage]["CurrentBalance"], currentCard.Balance.ToString("C"));
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(translations[selectedLanguage]["CurrentBalance"], currentCard.Balance.ToString("C")),
                translations[selectedLanguage]["Balance"]);
            LogAction("Balance checked");
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            pnlMainMenu.Visible = false;
            pnlTransaction.Visible = true;
            lblTransactionType.Text = translations[selectedLanguage]["Withdraw"];
            btnConfirm.Tag = "withdraw";
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            pnlMainMenu.Visible = false;
            pnlTransaction.Visible = true;
            lblTransactionType.Text = translations[selectedLanguage]["Deposit"];
            btnConfirm.Tag = "deposit";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show(translations[selectedLanguage]["InvalidCard"]);
                return;
            }

            string transactionType = btnConfirm.Tag.ToString();
            decimal commission = 0;

            bool isSameBank = currentCard.BankName == _atmBank.Name;

            if (transactionType == "withdraw" && !isSameBank)
            {
                commission = amount * _atmBank.Commission / 100;
                MessageBox.Show(string.Format(translations[selectedLanguage]["Commission"], _atmBank.Commission));
            }

            decimal totalAmount = transactionType == "withdraw" ? amount + commission : amount;

            if (transactionType == "withdraw" && currentCard.Balance < totalAmount)
            {
                MessageBox.Show(translations[selectedLanguage]["InsufficientFunds"]);
                return;
            }

            if (transactionType == "withdraw")
                currentCard.Balance -= totalAmount;
            else
                currentCard.Balance += amount;

            lblCurrentBalance.Text = string.Format(translations[selectedLanguage]["CurrentBalance"], currentCard.Balance.ToString("C"));
            MessageBox.Show(translations[selectedLanguage]["TransactionCompleted"]);
            pnlTransaction.Visible = false;
            pnlMainMenu.Visible = true;
            txtAmount.Text = "";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlTransaction.Visible = false;
            pnlMainMenu.Visible = true;
            txtAmount.Text = "";
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.Title = translations[selectedLanguage]["PrintReceipt"];
            saveFileDialog.FileName = $"receipt_{DateTime.Now:yyyyMMddHHmmss}.json";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Receipt receipt = new Receipt
                {
                    CardNumber = MaskCardNumber(currentCard.CardNumber),
                    TransactionDate = DateTime.Now,
                    PreviousBalance = _initialBalance,
                    TransactionAmount = _initialBalance - currentCard.Balance,
                    CurrentBalance = currentCard.Balance,
                    TransactionType = "Balance check"
                };

                string json = JsonSerializer.Serialize(receipt, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(saveFileDialog.FileName, json);

                MessageBox.Show(string.Format(translations[selectedLanguage]["ReceiptPrinted"], saveFileDialog.FileName));
                LogAction($"Receipt printed to {saveFileDialog.FileName}");
            }
        }

        private string MaskCardNumber(string cardNumber)
        {
            if (string.IsNullOrEmpty(cardNumber) || cardNumber.Length < 4) return cardNumber;
            return new string('*', cardNumber.Length - 4) + cardNumber.Substring(cardNumber.Length - 4);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnlMainMenu.Visible = false;
            pnlCardDetails.Visible = true;
            currentCard = null;
            txtCardNumber.Text = "";
            txtExpiryDate.Text = "";
            txtCVV.Text = "";
            txtPIN.Text = "";
            LogAction("User exited the session");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void lblSelectLanguage_Click(object sender, EventArgs e)
        {

        }

        private void lblCardNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblExpiryDate_Click(object sender, EventArgs e)
        {

        }

        private void lblTransactionType_Click(object sender, EventArgs e)
        {

        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            pnlCardDetails.Visible = false;
            pnlLanguage.Visible = true;
            txtAmount.Text = "";
            LogAction("User returned to language selection");
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}