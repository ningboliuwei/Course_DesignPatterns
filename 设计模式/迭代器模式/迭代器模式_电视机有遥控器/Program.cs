#region

using 迭代器模式_电视机有遥控器;

#endregion

var television = new Television();
var remote = new Remote(television);

while (remote.HasNext()) {
    remote.Next();
    var channel = remote.GetCurrentItem();
    Console.WriteLine($"[{channel.ChannelNumber}]{channel.ChannelName} ");
}

Console.ReadKey();