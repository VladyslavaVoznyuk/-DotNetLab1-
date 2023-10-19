using System;
using System.Text;
using ClassLibrary;

namespace ConsoleApp {
    internal class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            Bank bank = new Bank("Укрбанк", "Вулиця Велика Бердичівська 02, м. Житомир,10032");
            AutomatedTellerMachine automatedTellerMachine = new AutomatedTellerMachine("Вулиця Князів Острозьких 8, м.Житомир,10029");
            bank.AutomatedTellerMachines.Add(automatedTellerMachine);
            Console.WriteLine("Введіть своє ім'я:");
            string name = Console.ReadLine();
            Account account = new Account(name);
            account.Authorizated += ShowAccountMessage;
            string cardNumber, cardPIN;
            bool validation;
            do {
                Console.WriteLine("Введіть номер карти:");
                cardNumber = Console.ReadLine();
                Console.WriteLine("Введіть Pin код до карти:");
                cardPIN = Console.ReadLine();
                Console.WriteLine("Введіть баланс вашої карти:");
                double.TryParse(Console.ReadLine(), out double balance);
                validation = account.ValidateAuthorization(cardNumber, cardPIN);
                if (validation) {
                    account.CardNumber = cardNumber;
                    account.CardPIN = cardPIN;
                    account.Balance = balance;
                    account.Added += ShowAccountBalanceMessage;
                    account.CheckedBalance += ShowAccountMessage;
                    account.Withdrawn += ShowAccountBalanceMessage;
                    account.Transferred += ShowAccountBalanceMessage;
                    automatedTellerMachine.CheckedBalance += ShowAutomatedTellerMachineMessage;
                }
            } while (!validation);
            Console.WriteLine("Виберіть опції меню:");
            int menuOption;
            do {
                Console.WriteLine("1 Переглянути баланс карти.");
                Console.WriteLine("2 Поповнити гроші.");
                Console.WriteLine("3 Зняти гроші.");
                Console.WriteLine("4 Здійснити переказ на іншу карту.");
                Console.WriteLine("5 Переглянути баланс банкомату.");
                Console.WriteLine("0 to exit.");
                int.TryParse(Console.ReadLine(), out menuOption);
                switch (menuOption) {
                    case 0:
                        break;
                    case 1:
                        account.CheckBalance();
                        break;
                    case 2:
                        Console.WriteLine("Введіть суму вводу на карту:");
                        double.TryParse(Console.ReadLine(), out double sumToPut);
                        account.Put(sumToPut);
                        break;
                    case 3:
                        Console.WriteLine("Введіть суму,яку хочете зняти:");
                        double.TryParse(Console.ReadLine(), out double sumToWithdraw);
                        account.Withdraw(sumToWithdraw, automatedTellerMachine);
                        break;
                    
                    case 4:
                        string cardNumberToTranserTo;
                        do {
                            Console.WriteLine("Введіть номер карти, на яку хочете здійснити переказ:");
                            cardNumberToTranserTo = Console.ReadLine();
                        } while (!account.ValidateAuthorization(cardNumberToTranserTo, "4966"));
                        Console.WriteLine($"Введіть суму яку хочете надіслати на {cardNumberToTranserTo} карту:");
                        double.TryParse(Console.ReadLine(), out double sumToTransfer);
                        Account accountToTransferTo = new Account {
                            CardNumber = cardNumberToTranserTo
                        };
                        account.Transfer(sumToTransfer, accountToTransferTo);
                        break;
                    case 5:
                        automatedTellerMachine.CheckBalance();
                        break;
                    default:
                        Console.WriteLine("Такого пункту не існує.Спробуйте ще раз!");
                        break;
                }
            } while (menuOption != 0);
        }
        public static void ShowAccountMessage(object sender, AccountEventArgs e) {
            Console.WriteLine(e.Message);
        }
        public static void ShowAccountBalanceMessage(object sender, AccountBalanceEventArgs e) {
            Console.WriteLine($"{e.Message} Сума операції: {e.Sum} грн.");
        }
        public static void ShowAutomatedTellerMachineMessage(object sender, AutomatedTellerMachineEventArgs e) {
            Console.WriteLine(e.Message);
        }
    }
}