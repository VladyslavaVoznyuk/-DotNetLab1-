namespace ClassLibrary {
    public class AutomatedTellerMachineEventArgs {
        public string Message { get; }
        public AutomatedTellerMachineEventArgs(string message) {
            Message = message;
        }
    }
}