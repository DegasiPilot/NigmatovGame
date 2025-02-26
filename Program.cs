using System;
using System.Collections.Generic;

namespace NigmatovGame
{
	internal class Program
	{
		private static DungeonRoom[] DungeonMap;

		static void Main(string[] args)
		{
			Player player = new Player(5, 100, 0);
			DungeonMap = CreateDungeonMap(player);
			for(int i = 0; i < DungeonMap.Length; i++)
			{
				DungeonMap[i].EnterRoom();
				if(player.Health <= 0)
				{
					Console.WriteLine("Ваше здоровье упало до нуля. Вы погибли!");
					break;
				}
				for(int j = 1; j <= Console.BufferWidth; j++)
				{
					Console.Write('-');
				}
			}
		}

		static DungeonRoom[] CreateDungeonMap(Player player)
		{
			Random random = new Random();
			DungeonRoom[] map = new DungeonRoom[10];
			for(int i = 0; i < 9; i++)
			{
				map[i] = GenerateRoom(random, player);
			}
			map[9] = new BossRoom(player);
			return map;
		}

		static DungeonRoom GenerateRoom(Random random, Player player)
		{
			int room = random.Next(0,3);
			switch (room)
			{
				case 0:
					return new DungeonRoom(player);
				case 1:
					return new MonsterFigthRoom(player);
				case 2:
					return new TraderRoom(player);
				default:
					return new DungeonRoom(player);
			}
		}
	}
}
