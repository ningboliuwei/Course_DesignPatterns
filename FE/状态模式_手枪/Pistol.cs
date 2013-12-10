using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_手枪
{
	class Pistol
	{
		public int BulletCount { get; set; }

		private State m_currentState;

		public Pistol()
		{
			BulletCount = 3;
			m_currentState = new LoadedState(this);
		}

		public void Fire()
		{
			m_currentState.Fire();
		}

		public void Reload()
		{
			m_currentState.Reload();
		}

		public void SetState(State state)
		{
			m_currentState = state;
		}
	}
}