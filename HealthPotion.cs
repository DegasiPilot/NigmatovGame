using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigmatovGame
{
	internal class HealthPotion : InventoryItem
	{
		public override string Name => "Зелье лечения";

		public override void UseTo(Player player, Random random)
		{
			player.Health += random.Next(20);
		}
	}
}
