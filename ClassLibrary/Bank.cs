using System.Collections.Generic;

namespace ClassLibrary {
    public class Bank {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<AutomatedTellerMachine> AutomatedTellerMachines = new List<AutomatedTellerMachine>();
        public Bank(string name, string address) {
            Name = name;
            Address = address;
        }
    }
}