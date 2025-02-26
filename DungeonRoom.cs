using System;

namespace NigmatovGame
{
	internal class DungeonRoom
	{
		protected Player _player;

		public DungeonRoom(Player player)
		{
			_player = player;
		}

		public virtual void EnterRoom()
		{
			Console.WriteLine("Комната пуста! Вы идете дальше");
		}
	}
}