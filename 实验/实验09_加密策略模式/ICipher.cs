namespace 实验09_加密策略模式 {
    internal interface ICipher {
        string GetEncryptedText(string text);
    }
}