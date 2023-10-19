using System;

namespace ClassLibrary {
    public class AccountEventArgs : EventArgs {
        public string Message { get; }
        public AccountEventArgs(string message) {
            Message = message;
        }
    }
}