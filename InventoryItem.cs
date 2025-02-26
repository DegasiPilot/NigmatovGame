using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigmatovGame
{
	internal abstract class InventoryItem
	{
		public abstract string Name { get;}
		public abstract void UseTo(Player player, Random random);
	}
}
