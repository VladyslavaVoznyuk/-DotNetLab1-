using System;
using System.Windows.Forms;
using ClassLibrary;

namespace WinForm {
    public partial class AutomatedTellerMachineForm : Form {
        public AutomatedTellerMachineForm() {
            InitializeComponent();
            
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void AutomatedTellerMachineForm_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void MinimizeButton_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
        private void MachineCheckBalanceButton_Click(object sender, EventArgs e) {
            AuthorizationForm.automatedTellerMachine.CheckBalance();
        }
        private void CardCheckBalanceButton_Click(object sender, EventArgs e) {
            AuthorizationForm.account.CheckBalance();
        }
        private void PutButton_Click(object sender, EventArgs e) {
            AuthorizationForm.account.Put(Convert.ToDouble(PutSumTextBox.Text));
        }
        private void WithdrawButton_Click(object sender, EventArgs e) {
            AuthorizationForm.account.Withdraw(Convert.ToDouble(WithdrawSumTextBox.Text), AuthorizationForm.automatedTellerMachine);
        }
        private void TransferButton_Click(object sender, EventArgs e) {
            Account accountToTransferTo = new Account {
                CardNumber = TransferCardNumberTextBox.Text
            };
            AuthorizationForm.account.Transfer(Convert.ToDouble(TransferSumTextBox.Text), accountToTransferTo);
        }
    }
}