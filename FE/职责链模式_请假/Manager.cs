namespace 职责链模式_请假_职责链模式
{
	public abstract class Manager
	{
		protected string _name;

		protected Manager _superior;

		public Manager(string name)
		{
			_name = name;
		}

		public void SetSuperior(Manager superior)
		{
			_superior = superior;
		}

		public abstract void HandleApplications(Application application);
	}
}