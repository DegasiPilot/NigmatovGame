using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigmatovGame
{
	internal class Player
	{
		public Player(int arrows, int health, int money)
		{
			Arrows = arrows;
			Health = health;
			Money = money;
			Inventory = new InventoryItem[5]
			{
				new HealthPotion(),
				new HealthPotion(),
				new HealthPotion(),
				null,
				null
			};
		}

		public int Arrows { get; set; }
		public int Health { get; set; }
		public int Money { get; set; }
		public InventoryItem[] Inventory { get; }
	}
}
