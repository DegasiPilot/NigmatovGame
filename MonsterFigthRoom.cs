using System;

namespace NigmatovGame
{
	internal class MonsterFigthRoom : DungeonRoom
	{
		private int _monsterHealth;
		private Random random;

		public MonsterFigthRoom(Player player) : base(player)
		{
			random = new Random();
			_monsterHealth = random.Next(20, 50);
		}

		public override void EnterRoom()
		{
			Console.WriteLine($"Вы вошли в комнату с монстром. У мостра {_monsterHealth} жизней. У вас {_player.Arrows} стрел");
			do
			{
				string weapon = null;
				do
				{
					Console.WriteLine("Меч или лук?");
					weapon = Console.ReadLine().Trim().ToLower();
					if (weapon == "меч")
					{
						SwordAttack();
					}
					else if (weapon == "лук")
					{
						if (CanShootBow())
						{
							BowAttack();
						}
						else
						{
							Console.WriteLine("0 стрел!");
							weapon = null;
						}
					}
					else
					{
						weapon = null;
					}
				}
				while (weapon == null);

				if(_monsterHealth > 0)
				{
					int damage = random.Next(5, 15);
					_player.Health -= damage;
					Console.WriteLine($"Монстр атаковал игрока на {damage} урона. У игрока {_player.Health} жизней");
				}
			}
			while (_player.Health > 0 && _monsterHealth > 0);
			if(_player.Health > 0)
			{
				Console.WriteLine("Монстр повержен");
			}
		}

		public void SwordAttack()
		{
			Console.WriteLine("Удар мечом");
			int damage = random.Next(10, 20);
			_monsterHealth -= damage;
			Console.WriteLine($"Монстр получил {damage} урона. У монстра отсталось {_monsterHealth} жизней");
		}

		public void BowAttack()
		{
			Console.WriteLine("Выстрел из лука");
			int damage = random.Next(5, 15);
			_monsterHealth -= damage;
			Console.WriteLine($"Монстр получил {damage} урона. У монстра отсталось {_monsterHealth} жизней");
			_player.Arrows--;
			Console.WriteLine($"-1 стрела. Осталось стрел: {_player.Arrows}");
		}

		public bool CanShootBow() => _player.Arrows > 0;
	}
}
