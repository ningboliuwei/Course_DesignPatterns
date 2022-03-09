namespace 实验02_银行系统 {
    internal class Program {
        private static void Main(string[] args) {
            var bank = new Bank();

            bank.OpenAccount("2222", "2222", 20);
            bank.OpenAccount("3333", "3333", 50);

            var atm = new ATM(bank);

            for (var i = 0; i < 5; i++) {
                atm.Transaction();
            }
        }
    }
}