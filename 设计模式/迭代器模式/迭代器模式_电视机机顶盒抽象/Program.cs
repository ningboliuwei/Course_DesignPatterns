#region

using 迭代器模式_电视机机顶盒抽象;

#endregion

Console.WriteLine("Television Channels:");
var television = new Television();
var televisionRemote = new TelevisionRemote(television);
televisionRemote.ShowAllChannels();
Console.WriteLine();
Console.WriteLine("SetTopBox Channels:");
var setTopBox = new SetTopBox();
var setTopBoxRemote = new SetTopBoxRemote(setTopBox);
setTopBoxRemote.ShowAllChannels();

Console.ReadLine();