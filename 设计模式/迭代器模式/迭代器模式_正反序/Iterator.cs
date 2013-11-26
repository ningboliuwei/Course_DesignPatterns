namespace 迭代器模式_正反序
{
	internal interface IIterator
	{
		object First();

		object Next();

		object Last();

		object Current();
	}
}