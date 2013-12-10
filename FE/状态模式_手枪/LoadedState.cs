using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_手枪
{
	class LoadedState : State
	{
		public LoadedState(Pistol pistol)
		{
			m_pistol = pistol;
		}

		public override void Fire()
		{
			m_pistol.BulletCount--;
			Console.WriteLine("子弹发射，枪中还有{0}发子弹！", m_pistol.BulletCount);

			if (m_pistol.BulletCount == 0)
			{
				m_pistol.SetState(new EmptyState(m_pistol));
				Console.WriteLine("子弹打完了！");
			}
		}

		public override void Reload()
		{
			Console.WriteLine("枪中还有子弹，不能重填！");
		}
	}
}