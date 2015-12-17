namespace 职责链模式_请假_职责链模式
{
	public abstract class Manager
	{
		public string Name { get; set; }
		public Manager Superior { get; set; }

		public Manager(string name)
		{
			Name = name;
		}

		public abstract void HandleRequest(Request request);
	}
}