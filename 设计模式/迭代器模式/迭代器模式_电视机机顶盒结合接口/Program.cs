#region

using 迭代器模式_电视机机顶盒结合接口;

#endregion

// 以下两个二选一
// var television = new Television();
// var setTopBox = new SetTopBox();
// 可以进一步抽象为以下形式
IChannelAggregate aggregate = new SetTopBox();
var remote = aggregate.CreateRemote();

while (remote.HasNext()) {
    var currentChannel = remote.Next();
    Console.WriteLine($"[{currentChannel.ChannelNumber}]{currentChannel.ChannelName} ");
}

Console.ReadKey();