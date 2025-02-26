using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigmatovGame
{
	internal class TraderRoom : DungeonRoom
	{
		public TraderRoom(Player player) : base(player)
		{
		}

		public override void EnterRoom()
		{
			Console.WriteLine($"Вы вошли в магазин. Торговец предлагает купить зелье за 30 золота");
			Console.WriteLine($"У вас {_player.Money} монет. Хотите купить зелье? Да/Нет");
			string answer;
			do
			{
				answer = Console.ReadLine().Trim().ToLower();
				if (answer == "да")
				{
					if(_player.Money >= 30)
					{
						_player.Money -= 30;
						Console.WriteLine($"Вы купили зелье. Теперь у вас {_player.Money} монет");
					}
					else
					{
						Console.WriteLine("Торговец качает головой:\n- Вай-вай! Зачем обмануть пытаешься у тебя нет столько денег");
					}
				}
				else if(answer == "нет")
				{
					continue;
				}
				else
				{
					answer = null;
				}
			}
			while (answer == null);
		}
	}
}
