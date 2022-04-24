#region

using 迭代器模式_电视机机顶盒结合工厂;

#endregion

Console.WriteLine("Television Channels:");
var television = new Television();
var televisionRemote = television.CreateRemote();
televisionRemote.ShowAllChannels();
Console.WriteLine();
Console.WriteLine("SetTopBox Channels:");
var setTopBox = new SetTopBox();
var setTopBoxRemote = setTopBox.CreateRemote();
setTopBoxRemote.ShowAllChannels();
Console.ReadKey();