using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigmatovGame
{
	internal class BossRoom : DungeonRoom
	{
		public BossRoom(Player player) : base(player)
		{
		}

		public override void EnterRoom()
		{
			Console.WriteLine("Вы вошли в 10 комнату! Босс!");
			Console.WriteLine("В тз не написано что делать так что победа!");
		}
	}
}
