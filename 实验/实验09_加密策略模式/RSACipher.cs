#region

using System;
using System.Security.Cryptography;
using System.Text;

#endregion

namespace 实验09_加密策略模式 {
    internal class RSACipher : ICipher {
        public string GetEncryptedText(string text) {
            var param = new CspParameters();
            param.KeyContainerName = "key_container"; //密匙容器的名称，保持加密解密一致才能解密成功
            using (var rsa = new RSACryptoServiceProvider(param)) {
                var plaindata = Encoding.Default.GetBytes(text); //将要加密的字符串转换为字节数组
                var encryptdata = rsa.Encrypt(plaindata, false); //将加密后的字节数据转换为新的加密字节数组

                return Convert.ToBase64String(encryptdata); //将加密后的字节数组转换为字符串
            }
        }
    }
}