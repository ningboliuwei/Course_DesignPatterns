using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_手枪
{
	abstract class State
	{
		protected Pistol m_pistol;

		public abstract void Fire();

		public abstract void Reload();
	}
}