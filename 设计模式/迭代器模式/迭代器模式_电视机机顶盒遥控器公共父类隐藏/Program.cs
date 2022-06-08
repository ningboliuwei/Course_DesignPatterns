#region

using 迭代器模式_电视机机顶盒遥控器公共父类隐藏;

#endregion

var television = new Television();
var setTopBox = new SetTopBox();

IRemote televisionRemote = television.CreateRemote();
IRemote setTopBoxRemote = setTopBox.CreateRemote();

Helper.ShowAllChannels(televisionRemote);
Helper.ShowAllChannels(setTopBoxRemote);

Console.ReadKey();