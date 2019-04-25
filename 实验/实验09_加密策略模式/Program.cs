﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验09_加密策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入要加密的字符串：");
            var text = Console.ReadLine();
            Console.Write("请选择加密算法：1. MD5 2. SHA 3. RSA\n");
            var option = Convert.ToInt32(Console.ReadLine()) - 1;

            var context = new CipherContext();

            if (option == 1)
            {
                context.Cipher = new MD5Cipher();
            }
            else if (option == 2)
            {
                context.Cipher = new SHACipher();
            }
            else if (option == 2)
            {
                context.Cipher = new RSACipher();
            }

            Console.WriteLine($"加密后的字符串为：{context.Encrypt(text)}");

            Console.ReadKey();
        }
    }
}