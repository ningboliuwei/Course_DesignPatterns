#region

using 迭代器模式_电视机机顶盒遥控器公共父类;

#endregion

var television = new Television();
var setTopBox = new SetTopBox();

IRemote televisionRemote = new TelevisionRemote(television);
IRemote setTopBoxRemote = new SetTopBoxRemote(setTopBox);

Helper.ShowAllChannels(televisionRemote);
Helper.ShowAllChannels(setTopBoxRemote);

Console.ReadKey();