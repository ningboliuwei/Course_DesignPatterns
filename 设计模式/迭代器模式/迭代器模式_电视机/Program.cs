#region

using 迭代器模式_电视机;

#endregion

var television = new Television();
var remote = new Remote(television);
remote.ShowAllChannels();

Console.ReadKey();