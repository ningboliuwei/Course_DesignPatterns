namespace 实验09_加密策略模式 {
    internal class CipherContext {
        public ICipher Cipher { get; set; }

        public string Encrypt(string text) {
            if (Cipher != null) {
                return Cipher.GetEncryptedText(text);
            }

            return "";
        }
    }
}