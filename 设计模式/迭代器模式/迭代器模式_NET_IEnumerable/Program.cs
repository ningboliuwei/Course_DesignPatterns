#region

using System;
using 迭代器模式_NET_IEnumerable;

#endregion

var spectrum = new Spectrum();

foreach (string color in spectrum) {
    Console.WriteLine(color);
}