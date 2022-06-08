#region

using 迭代器模式_电视机机顶盒迭代器模式;

#endregion

var television = new Television();
var televisionRemote = television.CreateIterator();

while (televisionRemote.HasNext()) {
    televisionRemote.Next();
    var channel = televisionRemote.GetCurrentItem();
    Console.WriteLine($"[{channel.ChannelNumber}]{channel.ChannelName} ");
}

Console.WriteLine();

var setTopBox = new SetTopBox();
var setTopBoxRemote = setTopBox.CreateIterator();

while (setTopBoxRemote.HasNext()) {
    setTopBoxRemote.Next();
    var channel = setTopBoxRemote.GetCurrentItem();
    Console.WriteLine($"[{channel.ChannelNumber}]{channel.ChannelName} ");
}

Console.ReadKey();