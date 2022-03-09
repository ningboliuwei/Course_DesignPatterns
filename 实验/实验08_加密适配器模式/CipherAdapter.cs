namespace 实验08_加密适配器模式 {
    internal class CipherAdapter : ICipher {
        private readonly NewCipher _ciper = new NewCipher();

        public string Encrypt(string text) {
            return _ciper.GetMD5(text);
        }
    }
}