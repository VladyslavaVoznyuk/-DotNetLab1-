using System;
using System.Windows.Forms;
using ClassLibrary;

namespace WinForm {
    public partial class AuthorizationForm : Form {
        public AuthorizationForm() {
            InitializeComponent();
        }
        AutomatedTellerMachineForm automatedTellerMachineForm = new AutomatedTellerMachineForm();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public static Account account;
        public static Bank bank;
        public static AutomatedTellerMachine automatedTellerMachine;
        private void AuthorizationForm_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void CancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void AuthorizeButton_Click(object sender, EventArgs e) {
            bank = new Bank("Укрбанк", "Вулиця Велика Бердичівська 02, м. Житомир,10032");
            automatedTellerMachine = new AutomatedTellerMachine("Вулиця Князів Острозьких 8, м.Житомир,10029");
            bank.AutomatedTellerMachines.Add(automatedTellerMachine);
            account = new Account(NameTextBox.Text);
            account.Authorizated += ShowMessage;
            if (account.ValidateAuthorization(CardNumberTextBox.Text, CardPINTextBox.Text)) {
                account.CardNumber = CardNumberTextBox.Text;
                account.CardPIN = CardPINTextBox.Text;
                account.Balance = double.Parse(BalanceTextBox.Text); ;
                account.Added += ShowAccountBalanceMessage;
                account.CheckedBalance += ShowAccountMessage;
                account.Withdrawn += ShowAccountBalanceMessage;
                account.Transferred += ShowAccountBalanceMessage;
                automatedTellerMachine.CheckedBalance += ShowAutomatedTellerMachineMessage;
                this.Hide();
                automatedTellerMachineForm.BankNameLabel.Text = $"Ім'я банку: {bank.Name}";
                automatedTellerMachineForm.BankAddressLabel.Text = "Головний офіс за адресом:" + bank.Address;
                automatedTellerMachineForm.MachineIDLabel.Text = "Індетифікатор банкомату:" + automatedTellerMachine.ID.ToString();
                automatedTellerMachineForm.MachineAddressLabel.Text = "Адреса банкомату:" + automatedTellerMachine.Address;
                automatedTellerMachineForm.AccountNameLabel.Text = "Ім'я акауту:" + account.Name;
                automatedTellerMachineForm.AccountCardNumberLabel.Text = "Номер карти:" + account.CardNumber;
                automatedTellerMachineForm.ShowDialog();
                this.Close();
            } else {
                MessageBox.Show("Ви ввели не правильно номер карти чи PIN-код.Спробуйте ще раз!");
            }
        }
        private static void ShowMessage(object sender, AccountEventArgs e) {
            MessageBox.Show(e.Message);
        }
        public static void ShowAccountMessage(object sender, AccountEventArgs e) {
            MessageBox.Show(e.Message);
        }
        public static void ShowAccountBalanceMessage(object sender, AccountBalanceEventArgs e) {
            MessageBox.Show($"{e.Message} Сума переказу: {e.Sum} грн.");
        }
        public static void ShowAutomatedTellerMachineMessage(object sender, AutomatedTellerMachineEventArgs e) {
            MessageBox.Show(e.Message);
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }
    }
}