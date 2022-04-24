#region

using 迭代器模式_电视机机顶盒;

#endregion

var television = new Television();
var televisionRemote = new TelevisionRemote(television);
televisionRemote.ShowAllChannels();

Console.WriteLine("-----------------------");

var setTopBox = new SetTopBox();
var setTopBoxRemote = new SetTopBoxRemote(setTopBox);
setTopBoxRemote.ShowAllChannels();

Console.ReadKey();