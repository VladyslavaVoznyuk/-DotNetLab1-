using System.Text.RegularExpressions;

namespace ClassLibrary {
    public class Account {
        public delegate void AccountStateHandler(object sender, AccountEventArgs e);
        public delegate void AccountBalanceStateHandler(object sender, AccountBalanceEventArgs e);
        public event AccountStateHandler Authorizated;
        public event AccountStateHandler CheckedBalance;
        public event AccountBalanceStateHandler Added;
        public event AccountBalanceStateHandler Withdrawn;
        public event AccountBalanceStateHandler Transferred;
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string CardPIN { get; set; }
        public double Balance { get; set; }
        public Account() { }
        public Account(string name) {
            Name = name;
        }
        public bool ValidateAuthorization(string cardNumber, string cardPIN) {
            if (Regex.IsMatch(cardNumber, "^\\d{16}$") && Regex.IsMatch(cardPIN, "^\\d{4}$")) {
                Authorizated(this, new AccountEventArgs($"Авторизація."));
                return true;
            } else {
                Authorizated(this, new AccountEventArgs($"Помилка введення даних."));
                return false;
            }
        }
        public void CheckBalance() {
            CheckedBalance(this, new AccountEventArgs($"Ваш баланс {Balance} грн."));
        } 
        public void Put(double sum) {
            Balance += sum;
            Added(this, new AccountBalanceEventArgs($"Гроші додали успішно.", sum));
        }
        public void Withdraw(double sum, AutomatedTellerMachine automatedTellerMachine) {
            if (sum <= Balance && sum <= automatedTellerMachine.TotalMoney) {
                Balance -= sum;
                automatedTellerMachine.TotalMoney -= sum;
                Withdrawn(this, new AccountBalanceEventArgs($"Гроші знято.", sum));
            } else if (sum >= Balance) {
                Withdrawn(this, new AccountBalanceEventArgs($"У вас не достатньо грошей.", sum));
            } else if (sum >= automatedTellerMachine.TotalMoney) {
                Withdrawn(this, new AccountBalanceEventArgs($"Не достатньо грошей в банкоматі.", sum));
            }  else {
                Withdrawn(this, new AccountBalanceEventArgs($"Вам і банкомату не вистачає грошей.", sum));
            }
        }
        public void Transfer(double sum, Account account) {
            if (sum <= Balance) {
                Balance -= sum;
                account.Balance += sum;
                Transferred(this, new AccountBalanceEventArgs($"Ви перевели тільки, що гроші на цей номер карти {account.CardNumber}", sum));
            } else {
                Transferred(this, new AccountBalanceEventArgs($"У вас немає такої суми грошей.", sum));
            }
        }
    }
}