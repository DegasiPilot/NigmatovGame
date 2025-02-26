using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigmatovGame
{
	internal class TrapRoom : DungeonRoom
	{
		public TrapRoom(Player player) : base(player)
		{
			
		}

		public override void EnterRoom()
		{
			int damage = new Random().Next(10, 20);
			Console.WriteLine($"Это ловушка! Вы потеряли {damage} жизней. Ваше здоровье: {_player.Health}");
		}
	}
}
