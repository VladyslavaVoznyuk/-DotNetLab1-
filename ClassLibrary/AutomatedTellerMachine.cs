using System;

namespace ClassLibrary {
    public class AutomatedTellerMachine {
        public delegate void AutomatedTellerMachineStateHandler(object sender, AutomatedTellerMachineEventArgs e);
        public event AutomatedTellerMachineStateHandler CheckedBalance;
        public double TotalMoney { get; set; }
        public int ID { get; set; }
        public string Address { get; set; }
        public AutomatedTellerMachine(string address) {
            TotalMoney = new Random().Next(0, 1000000);
            ID = new Random().Next(0, 1000);
            Address = address;
        }
        public void CheckBalance() {
            CheckedBalance(this, new AutomatedTellerMachineEventArgs($"Баланс автомату: {TotalMoney} грн"));
        } 
    }
}