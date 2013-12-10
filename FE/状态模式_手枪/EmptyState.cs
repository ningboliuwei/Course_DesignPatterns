using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_手枪
{
	class EmptyState : State
	{
		public EmptyState(Pistol pistol)
		{
			m_pistol = pistol;
		}

		public override void Fire()
		{
			Console.WriteLine("枪中没有子弹了，无法发射！");
		}

		public override void Reload()
		{
			m_pistol.SetState(new LoadedState(m_pistol));
			m_pistol.BulletCount = 3;
			Console.WriteLine("重填了，枪中又装满了3发子弹！");
		}
	}
}