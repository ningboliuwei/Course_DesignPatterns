#region

using 迭代器模式_电视机机顶盒有遥控器;

#endregion

var television = new Television();
var televisionRemote = new TelevisionRemote(television);

while (televisionRemote.HasNext()) {
    televisionRemote.Next();
    var channel = televisionRemote.GetCurrentItem();
    Console.WriteLine($"[{channel.ChannelNumber}]{channel.ChannelName} ");
}

Console.WriteLine();

var setTopBox = new SetTopBox();
var setTopBoxRemote = new SetTopBoxRemote(setTopBox);

while (setTopBoxRemote.HasNext()) {
    setTopBoxRemote.Next();
    var channel = setTopBoxRemote.GetCurrentItem();
    Console.WriteLine($"[{channel.ChannelNumber}]{channel.ChannelName} ");
}

Console.ReadKey();